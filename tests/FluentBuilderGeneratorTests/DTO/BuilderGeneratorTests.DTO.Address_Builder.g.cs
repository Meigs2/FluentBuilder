//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilder
{
    public partial class AddressBuilder : Builder<Address>
    {
        private bool _houseNumberIsSet;
        private Lazy<int> _houseNumber = new Lazy<int>(() => default(int));
        public AddressBuilder WithHouseNumber(int value) => WithHouseNumber(() => value);
        public AddressBuilder WithHouseNumber(Func<int> func)
        {
            _houseNumber = new Lazy<int>(func);
            _houseNumberIsSet = true;
            return this;
        }
        public AddressBuilder WithoutHouseNumber()
        {
            WithHouseNumber(() => default(int));
            _houseNumberIsSet = false;
            return this;
        }

        private bool _cityIsSet;
        private Lazy<string> _city = new Lazy<string>(() => default(string));
        public AddressBuilder WithCity(string value) => WithCity(() => value);
        public AddressBuilder WithCity(Func<string> func)
        {
            _city = new Lazy<string>(func);
            _cityIsSet = true;
            return this;
        }
        public AddressBuilder WithoutCity()
        {
            WithCity(() => default(string));
            _cityIsSet = false;
            return this;
        }

        private bool _arrayIsSet;
        private Lazy<string[]> _array = new Lazy<string[]>(() => default(string[]));
        public AddressBuilder WithArray(string[] value) => WithArray(() => value);
        public AddressBuilder WithArray(Func<string[]> func)
        {
            _array = new Lazy<string[]>(func);
            _arrayIsSet = true;
            return this;
        }
        public AddressBuilder WithArray(Action<FluentBuilder.ArrayBuilder<String>> action, bool useObjectInitializer = true) => WithArray(() =>
        {
            var builder = new FluentBuilder.ArrayBuilder<String>();
            action(builder);
            return (string[]) builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutArray()
        {
            WithArray(() => default(string[]));
            _arrayIsSet = false;
            return this;
        }

        private bool _array2IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.Address[]> _array2 = new Lazy<FluentBuilderGeneratorTests.DTO.Address[]>(() => default(FluentBuilderGeneratorTests.DTO.Address[]));
        public AddressBuilder WithArray2(FluentBuilderGeneratorTests.DTO.Address[] value) => WithArray2(() => value);
        public AddressBuilder WithArray2(Func<FluentBuilderGeneratorTests.DTO.Address[]> func)
        {
            _array2 = new Lazy<FluentBuilderGeneratorTests.DTO.Address[]>(func);
            _array2IsSet = true;
            return this;
        }
        public AddressBuilder WithArray2(Action<FluentBuilder.ArrayAddressBuilder> action, bool useObjectInitializer = true) => WithArray2(() =>
        {
            var builder = new FluentBuilder.ArrayAddressBuilder();
            action(builder);
            return (FluentBuilderGeneratorTests.DTO.Address[]) builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutArray2()
        {
            WithArray2(() => default(FluentBuilderGeneratorTests.DTO.Address[]));
            _array2IsSet = false;
            return this;
        }

        private bool _enumerableIsSet;
        private Lazy<System.Collections.Generic.IEnumerable<byte>> _enumerable = new Lazy<System.Collections.Generic.IEnumerable<byte>>(() => default(System.Collections.Generic.IEnumerable<byte>));
        public AddressBuilder WithEnumerable(System.Collections.Generic.IEnumerable<byte> value) => WithEnumerable(() => value);
        public AddressBuilder WithEnumerable(Func<System.Collections.Generic.IEnumerable<byte>> func)
        {
            _enumerable = new Lazy<System.Collections.Generic.IEnumerable<byte>>(func);
            _enumerableIsSet = true;
            return this;
        }
        public AddressBuilder WithEnumerable(Action<FluentBuilder.IEnumerableBuilder<Byte>> action, bool useObjectInitializer = true) => WithEnumerable(() =>
        {
            var builder = new FluentBuilder.IEnumerableBuilder<Byte>();
            action(builder);
            return builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutEnumerable()
        {
            WithEnumerable(() => default(System.Collections.Generic.IEnumerable<byte>));
            _enumerableIsSet = false;
            return this;
        }

        private bool _enumerable2IsSet;
        private Lazy<System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>> _enumerable2 = new Lazy<System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>>(() => default(System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>));
        public AddressBuilder WithEnumerable2(System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address> value) => WithEnumerable2(() => value);
        public AddressBuilder WithEnumerable2(Func<System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>> func)
        {
            _enumerable2 = new Lazy<System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>>(func);
            _enumerable2IsSet = true;
            return this;
        }
        public AddressBuilder WithEnumerable2(Action<FluentBuilder.IEnumerableAddressBuilder> action, bool useObjectInitializer = true) => WithEnumerable2(() =>
        {
            var builder = new FluentBuilder.IEnumerableAddressBuilder();
            action(builder);
            return builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutEnumerable2()
        {
            WithEnumerable2(() => default(System.Collections.Generic.IEnumerable<FluentBuilderGeneratorTests.DTO.Address>));
            _enumerable2IsSet = false;
            return this;
        }

        private bool _listIsSet;
        private Lazy<System.Collections.Generic.List<string>> _list = new Lazy<System.Collections.Generic.List<string>>(() => default(System.Collections.Generic.List<string>));
        public AddressBuilder WithList(System.Collections.Generic.List<string> value) => WithList(() => value);
        public AddressBuilder WithList(Func<System.Collections.Generic.List<string>> func)
        {
            _list = new Lazy<System.Collections.Generic.List<string>>(func);
            _listIsSet = true;
            return this;
        }
        public AddressBuilder WithList(Action<FluentBuilder.IListBuilder<String>> action, bool useObjectInitializer = true) => WithList(() =>
        {
            var builder = new FluentBuilder.IListBuilder<String>();
            action(builder);
            return (System.Collections.Generic.List<string>) builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutList()
        {
            WithList(() => default(System.Collections.Generic.List<string>));
            _listIsSet = false;
            return this;
        }

        private bool _list2IsSet;
        private Lazy<System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>> _list2 = new Lazy<System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>>(() => default(System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>));
        public AddressBuilder WithList2(System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address> value) => WithList2(() => value);
        public AddressBuilder WithList2(Func<System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>> func)
        {
            _list2 = new Lazy<System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>>(func);
            _list2IsSet = true;
            return this;
        }
        public AddressBuilder WithList2(Action<FluentBuilder.IListAddressBuilder> action, bool useObjectInitializer = true) => WithList2(() =>
        {
            var builder = new FluentBuilder.IListAddressBuilder();
            action(builder);
            return (System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>) builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutList2()
        {
            WithList2(() => default(System.Collections.Generic.List<FluentBuilderGeneratorTests.DTO.Address>));
            _list2IsSet = false;
            return this;
        }

        private bool _collectionIsSet;
        private Lazy<System.Collections.Generic.ICollection<long>> _collection = new Lazy<System.Collections.Generic.ICollection<long>>(() => default(System.Collections.Generic.ICollection<long>));
        public AddressBuilder WithCollection(System.Collections.Generic.ICollection<long> value) => WithCollection(() => value);
        public AddressBuilder WithCollection(Func<System.Collections.Generic.ICollection<long>> func)
        {
            _collection = new Lazy<System.Collections.Generic.ICollection<long>>(func);
            _collectionIsSet = true;
            return this;
        }
        public AddressBuilder WithCollection(Action<FluentBuilder.ICollectionBuilder<Int64>> action, bool useObjectInitializer = true) => WithCollection(() =>
        {
            var builder = new FluentBuilder.ICollectionBuilder<Int64>();
            action(builder);
            return builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutCollection()
        {
            WithCollection(() => default(System.Collections.Generic.ICollection<long>));
            _collectionIsSet = false;
            return this;
        }

        private bool _collection2IsSet;
        private Lazy<System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>> _collection2 = new Lazy<System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>>(() => default(System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>));
        public AddressBuilder WithCollection2(System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address> value) => WithCollection2(() => value);
        public AddressBuilder WithCollection2(Func<System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>> func)
        {
            _collection2 = new Lazy<System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>>(func);
            _collection2IsSet = true;
            return this;
        }
        public AddressBuilder WithCollection2(Action<FluentBuilder.ICollectionAddressBuilder> action, bool useObjectInitializer = true) => WithCollection2(() =>
        {
            var builder = new FluentBuilder.ICollectionAddressBuilder();
            action(builder);
            return builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutCollection2()
        {
            WithCollection2(() => default(System.Collections.Generic.ICollection<FluentBuilderGeneratorTests.DTO.Address>));
            _collection2IsSet = false;
            return this;
        }

        private bool _iDictionaryIsSet;
        private Lazy<System.Collections.IDictionary> _iDictionary = new Lazy<System.Collections.IDictionary>(() => default(System.Collections.IDictionary));
        public AddressBuilder WithIDictionary(System.Collections.IDictionary value) => WithIDictionary(() => value);
        public AddressBuilder WithIDictionary(Func<System.Collections.IDictionary> func)
        {
            _iDictionary = new Lazy<System.Collections.IDictionary>(func);
            _iDictionaryIsSet = true;
            return this;
        }
        public AddressBuilder WithoutIDictionary()
        {
            WithIDictionary(() => default(System.Collections.IDictionary));
            _iDictionaryIsSet = false;
            return this;
        }

        private bool _iDictionary2IsSet;
        private Lazy<System.Collections.Generic.IDictionary<string, int>> _iDictionary2 = new Lazy<System.Collections.Generic.IDictionary<string, int>>(() => default(System.Collections.Generic.IDictionary<string, int>));
        public AddressBuilder WithIDictionary2(System.Collections.Generic.IDictionary<string, int> value) => WithIDictionary2(() => value);
        public AddressBuilder WithIDictionary2(Func<System.Collections.Generic.IDictionary<string, int>> func)
        {
            _iDictionary2 = new Lazy<System.Collections.Generic.IDictionary<string, int>>(func);
            _iDictionary2IsSet = true;
            return this;
        }
        public AddressBuilder WithIDictionary2(Action<FluentBuilder.IDictionaryBuilder<String, Int32>> action, bool useObjectInitializer = true) => WithIDictionary2(() =>
        {
            var builder = new FluentBuilder.IDictionaryBuilder<String, Int32>();
            action(builder);
            return builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutIDictionary2()
        {
            WithIDictionary2(() => default(System.Collections.Generic.IDictionary<string, int>));
            _iDictionary2IsSet = false;
            return this;
        }

        private bool _dictionary2IsSet;
        private Lazy<System.Collections.Generic.Dictionary<string, int>> _dictionary2 = new Lazy<System.Collections.Generic.Dictionary<string, int>>(() => default(System.Collections.Generic.Dictionary<string, int>));
        public AddressBuilder WithDictionary2(System.Collections.Generic.Dictionary<string, int> value) => WithDictionary2(() => value);
        public AddressBuilder WithDictionary2(Func<System.Collections.Generic.Dictionary<string, int>> func)
        {
            _dictionary2 = new Lazy<System.Collections.Generic.Dictionary<string, int>>(func);
            _dictionary2IsSet = true;
            return this;
        }
        public AddressBuilder WithDictionary2(Action<FluentBuilder.IDictionaryBuilder<String, Int32>> action, bool useObjectInitializer = true) => WithDictionary2(() =>
        {
            var builder = new FluentBuilder.IDictionaryBuilder<String, Int32>();
            action(builder);
            return (System.Collections.Generic.Dictionary<string, int>) builder.Build(useObjectInitializer);
        });
        public AddressBuilder WithoutDictionary2()
        {
            WithDictionary2(() => default(System.Collections.Generic.Dictionary<string, int>));
            _dictionary2IsSet = false;
            return this;
        }


        public override Address Build(bool useObjectInitializer = true)
        {
            if (Object?.IsValueCreated != true)
            {
                Object = new Lazy<Address>(() =>
                {
                    if (useObjectInitializer)
                    {
                        return new Address
                        {
                            HouseNumber = _houseNumber.Value,
                            City = _city.Value,
                            Array = _array.Value,
                            Array2 = _array2.Value,
                            Enumerable = _enumerable.Value,
                            Enumerable2 = _enumerable2.Value,
                            List = _list.Value,
                            List2 = _list2.Value,
                            Collection = _collection.Value,
                            Collection2 = _collection2.Value,
                            IDictionary = _iDictionary.Value,
                            IDictionary2 = _iDictionary2.Value,
                            Dictionary2 = _dictionary2.Value
                        };
                    }

                    var instance = new Address();
                    if (_houseNumberIsSet) { instance.HouseNumber = _houseNumber.Value; }
                    if (_cityIsSet) { instance.City = _city.Value; }
                    if (_arrayIsSet) { instance.Array = _array.Value; }
                    if (_array2IsSet) { instance.Array2 = _array2.Value; }
                    if (_enumerableIsSet) { instance.Enumerable = _enumerable.Value; }
                    if (_enumerable2IsSet) { instance.Enumerable2 = _enumerable2.Value; }
                    if (_listIsSet) { instance.List = _list.Value; }
                    if (_list2IsSet) { instance.List2 = _list2.Value; }
                    if (_collectionIsSet) { instance.Collection = _collection.Value; }
                    if (_collection2IsSet) { instance.Collection2 = _collection2.Value; }
                    if (_iDictionaryIsSet) { instance.IDictionary = _iDictionary.Value; }
                    if (_iDictionary2IsSet) { instance.IDictionary2 = _iDictionary2.Value; }
                    if (_dictionary2IsSet) { instance.Dictionary2 = _dictionary2.Value; }
                    return instance;
                });
            }

            PostBuild(Object.Value);

            return Object.Value;
        }

        public static Address Default() => new Address();

    }
}
#nullable disable