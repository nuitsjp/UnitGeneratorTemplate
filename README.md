[Japanese Document](https://zenn.dev/nuits_jp/articles/2022-05-19-unit-generator-template)

# UnitGeneratorTemplate

UnitGeneratorTemplate is a template package to automatically generate Value Objects using UnitGenerator in bulk by describing settings in CSV.

DDD's ValueObject requires a large amount of similar code to be written.

The [UnitGenerator](https://github.com/Cysharp/UnitGenerator) is a library that solves those issues.

It's very well done, and it scratches an itch, but it's a lot of work to produce large quantities of it...

UnitGeneratorTemplate is a solution to that problem.

Using the T4 template and CSV, you can create arbitrary Value Objects using UnitGenerator in bulk.

# Getting Started

Install UnitGenerator and UnitGeneratorTemplate from NuGet.

- NuGet:[UnitGenerator](https://www.nuget.org/packages/UnitGenerator/)
- NuGet:[UnitGeneratorTemplate](https://www.nuget.org/packages/UnitGeneratorTemplate/)


```powershell
Install-Package UnitGenerator
Install-Package UnitGeneratorTemplate
```

When the package is installed, two files are added.

- UnitGenerator.csv
- UnitGenerator.tt

Define the Unit you want to generate in UnitGenerator.csv and generate the code in UnitGenerator.tt.

The following screenshot shows a CSV opened with the "Edit csv" extension in Visual Studio Code.

![](/Images/edit-csv.png)


The CSV is specified as follows

|Column|Description|Example|
|--|--|--|
|Name|Name of struct to be generated|UnitId|
|Type|Value type|int|
|Description|Type comment of the struct to be generated|Value object representing the ID of the Unit|
|Format|ToString format|{0:###,###,###}|
|ImplicitOperator以降|Attributes specified for UnitGenerator.|Empty if not specified. If not specified, empty; if specified, other.|

After editing the CSV, open the UnitGenerator.tt file and press "Ctrl+s" or press "Run Custom Tool" from the UnitGenerator.tt context menu.

A UnitGenerator.cs file will then be created under UnitGenerator.tt as shown below.

![](/images/articles/2022-05-19-unit-generator-template/generated-unit.png)

# Validate

The use of Validate is somewhat different from other options.

When using Validate, you can specify the validation rule in one of the following ways.

1. Put the validation conditions in the Validate column of the CSV.
2. implement your own Validate method in a partial.

## Include the condition in the Validate column of the CSV.

For example, in the case of an int type Unit, if the value is less than 10, the Validate column should be as follows

|Name|Type|…|Validate|…|
|--|--|--|--|--|
|UserId|int||value < 10||

At this time, edit the UnitGenerator.tt file if you wish to change the exception class and message.

```cs
<#@ template debug="false" hostspecific="true" language="C#" #>
...
<#  
var validateException = "InvalidOperationException";
var validateExceptionMessage = "Invalid value range: {value}";
#>
```

Change validateException and validateExceptionMessage to any values.

## Implement your own Validate method in partial

In this case, only validation is specified in the CSV as follows.

|Name|Type|…|Validate|…|
|--|--|--|--|--|
|UserId|int||✔||

Any string of at least 1 and no more than 5 characters may be specified.

If it is longer than 6 characters, it is assumed that an expression is specified.

The Validate method should be implemented as partial as follows

```cs
public partial struct UserId
{
    private partial void Validate()
    {
        if (5 < value) throw new InvalidOperationException($"Invalid value range: {value}");
    }
}
```
