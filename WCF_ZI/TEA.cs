using System;
using System.IO;
using System.Linq;
using System.Text;

namespace WCF_ZI
{
	public class TEA
	{
		public static TEA instance;
		public const uint Rounds = 32;
		public uint[] key;

		#region Constructor
		public TEA()
		{
			key = null;
		}
		#endregion

		#region Instance
		public static TEA GetInstance()
		{
			if (instance != null)
				return instance;
			instance = new TEA();
			return instance;
		}
		#endregion

		#region Properties
		public uint[] Key
		{
			get { return key; }
			set
			{  //convert and create a valid key...
				key = CreateKey(Encoding.Unicode.GetBytes(System.Text.Encoding.ASCII.GetString(value.SelectMany(BitConverter.GetBytes).ToArray()).ToCharArray()));
			}
		}
		#endregion

		#region Encrypt and Decrypt
		public string Encrypt(string data)
		{
			var dataBytes = Encoding.Unicode.GetBytes(data);
			var result = EncryptByteStream(dataBytes);
			return Convert.ToBase64String(result);
		}


		public string Decrypt(string data)
		{
			var dataBytes = Convert.FromBase64String(data);
			var result = DecryptByteStream(dataBytes);
			return Encoding.Unicode.GetString(result);
		}
		public byte[] EncryptByteStream(byte[] data)
		{
			var blockBuffer = new uint[2];
			var result = new byte[NextMultipleOf8(data.Length + 4)]; //PADDING
			var lengthBuffer = BitConverter.GetBytes(data.Length);
			Array.Copy(lengthBuffer, result, lengthBuffer.Length);
			Array.Copy(data, 0, result, lengthBuffer.Length, data.Length);

			using (var stream = new MemoryStream(result))
			{
				using (var writer = new BinaryWriter(stream))
					for (int i = 0; i < result.Length; i += 8)
					{
						blockBuffer[0] = BitConverter.ToUInt32(result, i);
						blockBuffer[1] = BitConverter.ToUInt32(result, i + 4);
						EncryptUIntStream(Rounds, blockBuffer);
						writer.Write(blockBuffer[0]);
						writer.Write(blockBuffer[1]);
					}
			}
			return result;
		}
		public byte[] DecryptByteStream(byte[] data)
		{
			if (data.Length % 8 != 0) throw new ArgumentException("Encrypted data length must be a multiple of 8 bytes.");
			var blockBuffer = new uint[2];
			var buffer = new byte[data.Length];
			Array.Copy(data, buffer, data.Length);
			using (MemoryStream stream = new MemoryStream(buffer))
			{
				using (BinaryWriter writer = new BinaryWriter(stream))
					for (int i = 0; i < buffer.Length; i += 8)
					{
						blockBuffer[0] = BitConverter.ToUInt32(buffer, i);
						blockBuffer[1] = BitConverter.ToUInt32(buffer, i + 4);
						DecryptUIntStream(Rounds, blockBuffer);
						writer.Write(blockBuffer[0]);
						writer.Write(blockBuffer[1]);
					}
			}
			// verify valid length
			var length = BitConverter.ToUInt32(buffer, 0);
			if (length > buffer.Length - 4) throw new ArgumentException("Invalid encrypted data");
			var result = new byte[length];
			Array.Copy(buffer, 4, result, 0, length);
			return result;
		}
		#endregion

		#region Methods
		public static int NextMultipleOf8(int length)
		{
			// TEA should be 64-bit block chiffre, therefore our data must be a multiple of 64 bit
			return (length + 7) / 8 * 8; // this will give us the next multiple of 8
		}
		public static uint[] CreateKey(byte[] key)
		{
			var hash = new byte[16];
			for (int i = 0; i < key.Length; i++)
			{
				hash[i % 16] = (byte)((31 * hash[i % 16]) ^ key[i]);
			}
			for (int i = key.Length; i < hash.Length; i++)
			{ // if key was too short
				hash[i] = (byte)(17 * i ^ key[i % key.Length]);
			}
			return new[] {
				BitConverter.ToUInt32(hash, 0), BitConverter.ToUInt32(hash, 4),
				BitConverter.ToUInt32(hash, 8), BitConverter.ToUInt32(hash, 12)
			};
		}
		#endregion

		#region Block Operations
		public void EncryptUIntStream(uint rounds, uint[] v)
		{
			uint v0 = v[0], v1 = v[1], sum = 0, delta = 0x9E3779B9;
			for (uint i = 0; i < rounds; i++)
			{
				sum += delta;
				v0 += ((v1 << 4) + key[0]) ^ (v1 + sum) ^ ((v1 >> 5) + key[1]);
				v1 += ((v0 << 4) + key[2]) ^ (v0 + sum) ^ ((v0 >> 5) + key[3]);
			}
			v[0] = v0;
			v[1] = v1;
		}
		public void DecryptUIntStream(uint rounds, uint[] v)
		{
			uint v0 = v[0], v1 = v[1], delta = 0x9E3779B9, sum = 0xC6EF3720;

			for (uint i = 0; i < rounds; i++)
			{
				v1 -= ((v0 << 4) + key[2]) ^ (v0 + sum) ^ ((v0 >> 5) + key[3]);
				v0 -= ((v1 << 4) + key[0]) ^ (v1 + sum) ^ ((v1 >> 5) + key[1]);
				sum -= delta;
			}
			v[0] = v0;
			v[1] = v1;
		}
		#endregion



	}


}
