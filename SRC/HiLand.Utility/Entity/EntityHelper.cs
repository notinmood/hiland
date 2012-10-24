﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using HiLand.Utility.Data;

namespace HiLand.Utility.Entity
{
    public class EntityHelper
    {
        /// <summary>
        /// 浅克隆实体对象
        /// </summary>
        /// <typeparam name="T">实体对象的类型</typeparam>
        /// <param name="sourceEntity">源实体对象</param>
        /// <returns>克隆出的新实体对象</returns>
        public static T Clone<T>(T sourceEntity) where T : new()
        {
            return Converter.InheritedEntityConvert<T, T>(sourceEntity);
        }

        /// <summary>
        /// 深克隆实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceEntity"></param>
        /// <returns></returns>
        /// <remarks>
        /// 需要克隆的对象实体，必须标记特性[Serializable]
        /// </remarks>
        public static T DeepClone<T>(T sourceEntity)
        {
            T clonedEntity = default(T);
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memStream = new MemoryStream())
            {
                formatter.Serialize(memStream, sourceEntity);
                memStream.Seek(0, SeekOrigin.Begin);
                clonedEntity = (T)formatter.Deserialize(memStream);
            }

            return clonedEntity;
        }
    }
}
