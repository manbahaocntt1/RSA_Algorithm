﻿using System;
using System.Numerics;
using System.Text;

namespace RSA_Algorithm
{
    public class Program
    {
        
            static Random random = new Random();

            // Kiểm tra số nguyên tố
            public static bool IsPrimeNumber(int number)
            {
                if (number <= 1)
                    return false;

                if (number == 2 || number == 3)
                    return true;

                if (number % 2 == 0)
                    return false;

                int sqrt = (int)Math.Sqrt(number);

                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }

            // Tạo số nguyên tố ngẫu nhiên
            public static int GeneratePrimeNumber()
            {
                int primeNumber;

                while (true)
                {
                    primeNumber = random.Next(100, 10000);

                    if (IsPrimeNumber(primeNumber))
                        break;
                }

                return primeNumber;
            }

            // Hàm tính ước chung lớn nhất (GCD)
            public static BigInteger GCD(BigInteger a, BigInteger b)
            {
                while (b != 0)
                {
                    BigInteger remainder = a % b;
                    a = b;
                    b = remainder;
                }

                return a;
            }

            // Hàm chọn khóa công khai
            public static BigInteger ChoosePublicKey(BigInteger phi)
            {
                BigInteger publicKey;

                do
                {
                    publicKey = new BigInteger(random.Next(2, (int)phi - 1));
                }
                while (GCD(publicKey, phi) != 1);

                return publicKey;
            }

            // Hàm tìm nghịch đảo modulo
            public static BigInteger CalculatePrivateKey(BigInteger publicKey, BigInteger phi)
            {
                BigInteger privateKey = ModInverse(publicKey, phi);
                return privateKey;
            }

            public static BigInteger ModInverse(BigInteger a, BigInteger m)
            {
                BigInteger m0 = m;
                BigInteger y = 0;
                BigInteger x = 1;

                if (m == 1)
                    return 0;

                while (a > 1)
                {
                    BigInteger q = a / m;
                    BigInteger t = m;

                    m = a % m;
                    a = t;
                    t = y;

                    y = x - q * y;
                    x = t;
                }

                if (x < 0)
                    x += m0;

                return x;
            }
            public static BigInteger ModPow(BigInteger x, BigInteger exp, BigInteger n)
            {
                if (exp == 0)
                {
                    return 1;
                }
                if (exp == 1)
                {
                    return x % n;
                }
                BigInteger t = ModPow(x, exp / 2, n);
                t = (t * t) % n;
                if (exp % 2 == 0)
                    return t;
                else
                    return ((x % n) * t) % n;

            }
        public static long power_modulo(long  x, long  b, long  n)
        {
            if (b == 0)
            {
                return 1;
            }
            if (b == 1)
            {
                return x % n;
            }
            long t = power_modulo(x, b / 2, n);
            t = (t * t) % n;
            if (b % 2 == 0)
                return t;
            else
                return ((x % n) * t) % n;
        }
        


            public static string RsaEncrypt(string plaintext, BigInteger e, BigInteger n)
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                BigInteger[] encryptedCharCodes = new BigInteger[plaintextBytes.Length];
                

            for (int i = 0; i < plaintextBytes.Length; i++)
                {
                    BigInteger charCode = new BigInteger(plaintextBytes[i]);
                    encryptedCharCodes[i] = ModPow(charCode, e, n);
                }

                return string.Join(",", encryptedCharCodes);
            }

            public static string RsaDecrypt(string ciphertext, BigInteger d, BigInteger n)
            {
            string[] encryptedCharCodes = ciphertext.Split(',');
            byte[] decryptedBytes = new byte[encryptedCharCodes.Length];

            for (int i = 0; i < encryptedCharCodes.Length; i++)
            {
                BigInteger encryptedCharCode = BigInteger.Parse(encryptedCharCodes[i]);
                BigInteger decryptedCharCode = BigInteger.ModPow(encryptedCharCode, d, n);
                decryptedBytes[i] = (byte)decryptedCharCode;
            }

            return Encoding.UTF8.GetString(decryptedBytes);

        }

        
        

            static void Main(string[] args)
            {
           
            BigInteger p = GeneratePrimeNumber();
                BigInteger q = GeneratePrimeNumber();

                BigInteger n = BigInteger.Multiply(p, q);
                BigInteger phi = BigInteger.Multiply(p - 1, q - 1);
                BigInteger b = ChoosePublicKey(phi);
                BigInteger a = CalculatePrivateKey(b, phi);

                Console.WriteLine(p);
                Console.WriteLine(q);
                Console.WriteLine(n);
                Console.WriteLine(phi);
                Console.WriteLine(b);
                Console.WriteLine(a);
            Console.WriteLine(power_modulo(72, 479, 551));
            Console.WriteLine(power_modulo(250, 135, 551));
            Console.WriteLine(ModInverse(11,3));
            

            Console.WriteLine("Nhập thông điệp cần mã hóa:");
                string plaintext = Console.ReadLine();

                string encryptedText = RsaEncrypt(plaintext, b, n);
                Console.WriteLine("Thông điệp đã được mã hóa: " + encryptedText);
                Console.WriteLine("Thông điệp cần giải mã:" + encryptedText);

                Console.WriteLine("Thông điệp đã được giải mã: " + RsaDecrypt(encryptedText, a, n));

                Console.Read();
            }
        
    }
}