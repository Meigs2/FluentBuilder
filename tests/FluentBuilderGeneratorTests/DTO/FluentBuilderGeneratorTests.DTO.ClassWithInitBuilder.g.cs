//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.5.1.0
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
    public partial class ClassWithInitBuilder : Builder<FluentBuilderGeneratorTests.DTO.ClassWithInit>
    {
        private bool _normalIsSet;
        private Lazy<string> _normal = new Lazy<string>(() => string.Empty);
        public ClassWithInitBuilder WithNormal(string value) => WithNormal(() => value);
        public ClassWithInitBuilder WithNormal(Func<string> func)
        {
            _normal = new Lazy<string>(func);
            _normalIsSet = true;
            return this;
        }
        public ClassWithInitBuilder WithoutNormal()
        {
            WithNormal(() => string.Empty);
            _normalIsSet = false;
            return this;
        }

        private bool _idIsSet;
        private Lazy<int> _id = new Lazy<int>(() => default(int));
        public ClassWithInitBuilder WithId(int value) => WithId(() => value);
        public ClassWithInitBuilder WithId(Func<int> func)
        {
            _id = new Lazy<int>(func);
            _idIsSet = true;
            return this;
        }
        public ClassWithInitBuilder WithoutId()
        {
            WithId(() => default(int));
            _idIsSet = false;
            return this;
        }

        private bool _testIsSet;
        private Lazy<long> _test = new Lazy<long>(() => default(long));
        public ClassWithInitBuilder WithTest(long value) => WithTest(() => value);
        public ClassWithInitBuilder WithTest(Func<long> func)
        {
            _test = new Lazy<long>(func);
            _testIsSet = true;
            return this;
        }
        public ClassWithInitBuilder WithoutTest()
        {
            WithTest(() => default(long));
            _testIsSet = false;
            return this;
        }


        public override ClassWithInit Build(bool useObjectInitializer = true)
        {
            if (Object?.IsValueCreated != true)
            {
                Object = new Lazy<ClassWithInit>(() =>
                {
                    ClassWithInit instance;
                    if (useObjectInitializer)
                    {
                        instance = new ClassWithInit
                        {
                            Normal = _normal.Value,
                            Id = _id.Value,
                            Test = _test.Value
                        };
                        return instance;
                    }

                    instance = new ClassWithInit();
                    if (_normalIsSet) { instance.Normal = _normal.Value; }
                    return instance;
                });
            }

            PostBuild(Object.Value);

            return Object.Value;
        }

        public static ClassWithInit Default() => new ClassWithInit();

    }
}
#nullable disable