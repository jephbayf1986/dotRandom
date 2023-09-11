using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace dotRandom
{
    public static partial class DotRandom
    {
        /// <summary>
        /// Generate Random
        /// </summary>
        /// <typeparam name="T">Type to be generated</typeparam>
        /// <returns>Instance of type with Random values in attributes where possible</returns>
        public static T GenerateRandom<T>()
        {
            var returnType = typeof(T);

            T instance = Activator.CreateInstance<T>();

            var props = returnType.GetProperties();

            foreach (var prop in props)
            {
                instance.SetRandomProp(prop);
            }

            return instance;
        }

        private static void SetRandomProp<T>(this T parent, PropertyInfo childProperty)
        {
            if (childProperty.PropertyType == typeof(string))
            {
                childProperty.SetValue(parent, RandomString());
                return;
            }

            if (childProperty.PropertyType == typeof(long))
            {
                childProperty.SetValue(parent, RandomLongBetween(10000, long.MaxValue));
                return;
            }

            if (childProperty.PropertyType == typeof(int))
            {
                childProperty.SetValue(parent, RandomIntBetween(1000, 9999));
                return;
            }

            if (childProperty.PropertyType == typeof(short))
            {
                childProperty.SetValue(parent, RandomShortBetween(100, short.MaxValue));
                return;
            }

            if (childProperty.PropertyType == typeof(byte))
            {
                childProperty.SetValue(parent, RandomByteBetween(10, byte.MaxValue));
                return;
            }

            if (childProperty.PropertyType == typeof(DateTime))
            {
                childProperty.SetValue(parent, RandomDateInPast());
                return;
            }

            if (childProperty.PropertyType == typeof(bool))
            {
                childProperty.SetValue(parent, RandomBool());
                return;
            }

            if (childProperty.PropertyType == typeof(Guid))
            {
                childProperty.SetValue(parent, Guid.NewGuid());
                return;
            }

            if (childProperty.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
            {
                var genericTypes = childProperty.PropertyType.GetGenericArguments();

                var listType = typeof(List<>).MakeGenericType(genericTypes);

                childProperty.SetValue(parent, Activator.CreateInstance(listType));
            }
        }
    }
}