﻿using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using Wire.Extensions;
using Wire.ValueSerializers;

namespace Wire.SerializerFactories
{
    public class PropertyInfoSerializerFactory : ValueSerializerFactory
    {
        public override bool CanSerialize(Serializer serializer, Type type)
        {
            return type.GetTypeInfo().IsSubclassOf(typeof(PropertyInfo));
        }

        public override bool CanDeserialize(Serializer serializer, Type type)
        {
            return CanSerialize(serializer, type);
        }

        public override ValueSerializer BuildSerializer(Serializer serializer, Type type,
            ConcurrentDictionary<Type, ValueSerializer> typeMapping)
        {
            var os = new ObjectSerializer(type);
            typeMapping.TryAdd(type, os);
            ObjectReader reader = (stream, session) =>
            {
                var name = stream.ReadString(session);
                var owner = stream.ReadObject(session) as Type;

#if NET45
                var property = owner.GetTypeInfo().GetProperty(name, BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                return property;
#else
                return null;
#endif
            };
            ObjectWriter writer = (stream, obj, session) =>
            {
                var property = (PropertyInfo)obj;
                var name = property.Name;
                var owner = property.DeclaringType;
                StringSerializer.WriteValueImpl(stream, name, session);
                stream.WriteObjectWithManifest(owner, session);
            };
            os.Initialize(reader, writer);

            return os;
        }
    }
}