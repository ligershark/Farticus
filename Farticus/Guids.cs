// Guids.cs
// MUST match guids.h
using System;

namespace LigerShark.Farticus
{
    static class GuidList
    {
        public const string guidFarticusPkgString = "1324ce08-8b25-440c-1234-07e1fa0cce4a";
        public const string guidFarticusCmdSetString = "7a332164-9846-4bc6-a00f-bc7e6132f29a";

        public static readonly Guid guidFarticusCmdSet = new Guid(guidFarticusCmdSetString);
    };
}