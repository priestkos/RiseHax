﻿namespace RiseHax.Hunter
{
    public static class DataOffsets
    {
        // Offsets --> Use .ReadBytes()
        // None of these seem to be static wtf i hate demos
        public const uint OffsetHunterHP = 0x001DFC86FC;
        // Might just be Pouch slot 2(?)
        public const uint OffsetMegaPotion = 0x001D00BD54;

        // Pointers --> Use .ReadBytesAbsolute()
        public const string PointerHunterHP = "[[[main+CD73FA0]+390]+20]+10";
        public const string PointerHunterHPRecoverable = "[[[main+CD76310]+D0]+118]+1C";
        // Co-ords are directly after each other, 4 bytes each so add 0x04 to get the next co-ord.
        public const string PointerHunterCoordX = "[[[main+CDBBF88]+A0]+18]+30";
        // Item counts follow each other, add 0x08 to get the next item.
        public const string PointerPouchItems = "[[[main+CD7A060]+68]+70]+44";
    }
}
