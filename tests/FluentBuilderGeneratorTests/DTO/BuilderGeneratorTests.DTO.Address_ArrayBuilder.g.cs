//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.6.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using FluentBuilderGeneratorTests.FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilderGeneratorTests.DTO
{
    public partial class ArrayAddressBuilder : Builder<FluentBuilderGeneratorTests.DTO.Address[]>
    {
        private readonly Lazy<List<FluentBuilderGeneratorTests.DTO.Address>> _list = new Lazy<List<FluentBuilderGeneratorTests.DTO.Address>>(() => new List<FluentBuilderGeneratorTests.DTO.Address>());
        public ArrayAddressBuilder Add(Address item) => Add(() => item);
        public ArrayAddressBuilder Add(Func<Address> func)
        {
            _list.Value.Add(func());
            return this;
        }
        public ArrayAddressBuilder Add(Action<FluentBuilderGeneratorTests.DTO.AddressBuilder> action, bool useObjectInitializer = true)
        {
            var builder = new FluentBuilderGeneratorTests.DTO.AddressBuilder();
            action(builder);
            Add(() => builder.Build(useObjectInitializer));
            return this;
        }


        public override FluentBuilderGeneratorTests.DTO.Address[] Build(bool useObjectInitializer = true)
        {
            if (Object?.IsValueCreated != true)
            {
                Object = new Lazy<FluentBuilderGeneratorTests.DTO.Address[]>(() =>
                {
                    return _list.Value.ToArray();
                });
            }

            PostBuild(Object.Value);

            return Object.Value;
        }

    }
}
#nullable disable