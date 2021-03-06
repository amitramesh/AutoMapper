﻿using System;
using System.Linq;

namespace AutoMapper.Internal
{
    public class EnumNameValueMapperFactory : IEnumNameValueMapperFactory
    {
        public IEnumNameValueMapper Create()
        {
            return new EnumVameValueMapper();
        }

        private class EnumVameValueMapper : IEnumNameValueMapper
        {
            public bool IsMatch(Type enumDestinationType, string sourceValue)
            {
                return false;
            }

            public object Convert(Type enumSourceType, Type enumDestinationType, ResolutionContext context)
            {
                throw new NotSupportedException();
            }
        }
    }
}
