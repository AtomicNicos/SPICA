﻿using SPICA.Math3D;

using System.Xml.Serialization;

namespace SPICA.GenericFormats.COLLADA
{
    public class DAEVector3
    {
        [XmlAttribute] public string sid;

        [XmlText] public string data;

        public static DAEVector3 Empty
        {
            get
            {
                return new DAEVector3 { data = "0 0 0" };
            }
        }

        public void Set(Vector3D Vector)
        {
            data = Vector.ToSerializableString();
        }
    }
}