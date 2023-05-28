using System;

namespace PenCipher
{
    interface Cipher
    {
        string Text { get; set; }
        void Enter();
        void Shift();
    }
}