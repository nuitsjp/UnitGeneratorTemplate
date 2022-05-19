# UnitGeneratorTemplate

UnitGeneratorTemplateはCSVに設定を記載することで、UnitGeneratorを利用したValue Objectを一括で自動生成するためのテンプレートパッケージです。

T4テンプレートとCSVを利用して、任意のUnitを一括で作成できます。

# Getting Started

UnitGeneratorとUnitGeneratorTemplateをNuGetからインストールします。

- NuGet:[UnitGenerator](https://www.nuget.org/packages/UnitGenerator/)
- NuGet:[UnitGeneratorTemplate](https://www.nuget.org/packages/UnitGeneratorTemplate/)


```powershell
Install-Package UnitGenerator
Install-Package UnitGeneratorTemplate
```

パッケージをインストールすると、2つのファイルが追加されます。

- UnitGenerator.csv
- UnitGenerator.tt

UnitGenerator.csvに生成したいUnitを定義し、UnitGenerator.ttでコードを生成します。

![](/Images/edit-csv.png)

こちらはCSVをVisual Studio Codeの「Edit csv」拡張で開いたものです。

CSVにはつぎのように指定します。

|列|説明|指定例|
|--|--|--|
|Name|生成する構造体の名称|UnitId|
|Type|値の型|int|
|Description|生成する構造体のTypeコメント|UnitのIDを表す値オブジェクト|
|Format|ToString時のフォーマット|{0:###,###,###}|
|ImplicitOperator以降|UnitGeneratorに指定する属性|指定しない場合は空。指定する場合はそれ以外。|

CSVを編集したあと、UnitGenerator.ttファイルを開いて「Ctrl+s」を押すか、UnitGenerator.ttのコンテキストメニューから「カスタムツールの実行」を押します。

すると次のようにUnitGenerator.ttの下にUnitGenerator.csファイルが作成されます。

![](/Images/generated-unit.png)

