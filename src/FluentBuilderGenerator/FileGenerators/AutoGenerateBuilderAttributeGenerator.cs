// This source code is based on https://justsimplycode.com/2020/12/06/auto-generate-builders-using-source-generator-in-net-5

using FluentBuilderGenerator.Models;
using FluentBuilderGenerator.Types;

namespace FluentBuilderGenerator.FileGenerators;

internal class AutoGenerateBuilderAttributeGenerator : IFileGenerator
{
    private const string Name = "FluentBuilder.AutoGenerateBuilderAttribute.g.cs";

    private readonly string _assemblyName;
    private readonly bool _supportsNullable;
    
    public AutoGenerateBuilderAttributeGenerator(string assemblyName, bool supportsNullable)
    {
        _assemblyName = assemblyName;
        _supportsNullable = supportsNullable;
    }

    public FileData GenerateFile()
    {
        return new FileData
        (
            FileDataType.Attribute,
            Name,
            $@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

{(_supportsNullable ? "#nullable enable" : string.Empty)}
using System;

namespace FluentBuilder
{{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class AutoGenerateBuilderAttribute : Attribute
    {{
        public Type{(_supportsNullable ? "?" : string.Empty)} Type {{ get; }}

        public AutoGenerateBuilderAttribute(Type{(_supportsNullable ? "?" : string.Empty)} type = null)
        {{
            Type = type;
        }}
    }}

    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class IgnorePropertyAttribute : Attribute
    {{
    }}
}}
{(_supportsNullable ? "#nullable disable" : string.Empty)}"
        );
    }
}