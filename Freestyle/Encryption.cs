using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        var message = Console.ReadLine();

        Console.WriteLine(Encrypt(message));
    }
    
    private static string Encrypt(string message)
    {
        var length = message.Length;
        var lengthSqrt = Math.Sqrt(length);
        var lengthSqrtFloor = (int) Math.Floor(lengthSqrt);
        var lengthSqrtCeiling = (int) Math.Ceiling(lengthSqrt);
        var minArea = int.MaxValue;
        var rows = 0;
        var columns = 0;
        var encryptedMessage = string.Empty;
        
        for (var i = lengthSqrtFloor; i <= lengthSqrtCeiling; i++)
        {
            for (var j = i; j <= lengthSqrtCeiling; j++)
            {
                var area = i*j;
                
                if (area >= length && area < minArea)
                {
                    rows = i;
                    columns = j;
                }
            }
        }
        
        for (var i = 0; i < columns; i++)
        {
            for (var j = 0; j < rows; j++)
            {
                var index = i + j*columns;
                
                if (index < length) {
                    encryptedMessage += message[index];
                }
            }
            
            if (i < columns -1)
            {
                encryptedMessage += " ";
            }
        }
        
        return encryptedMessage;
    }
}
