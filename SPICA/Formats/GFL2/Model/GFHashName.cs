﻿namespace SPICA.Formats.GFL2.Model
{
    struct GFHashName
    {
        public uint Hash;
        public string Name;

        public GFHashName(uint Hash, string Name)
        {
            this.Hash = Hash;
            this.Name = Name;
        }
    }
}
