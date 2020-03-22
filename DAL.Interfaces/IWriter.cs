﻿using System;
using System.Collections.ObjectModel;
using System.Xml;

namespace DAL.Interfaces
{
    public interface IWriter<T>
    {
        void WriteToXml(string path, ReadOnlyCollection<T> collection);
    }
}