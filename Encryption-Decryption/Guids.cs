// Guids.cs
// MUST match guids.h
using System;

namespace bhojarajsahu88.Encryption_Decryption
{
    static class GuidList
    {
        public const string guidEncryption_DecryptionPkgString = "f7018173-be53-4772-9c4f-5f9f19490bd3";
        public const string guidEncryption_DecryptionCmdSetString = "b9d27989-4c6e-4789-8000-6d722c354316";

        public static readonly Guid guidEncryption_DecryptionCmdSet = new Guid(guidEncryption_DecryptionCmdSetString);
    };
}