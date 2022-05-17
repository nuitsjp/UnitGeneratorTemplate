param($installPath, $toolsPath, $package, $project)

$projectPath = Split-Path ($project.FullName)
$namespace = $project.Properties.Item("DefaultNamespace").Value

$sourceCsv = Join-Path ($toolsPath) UnitGenerator.csv
$destinationCsv = Join-Path ($projectPath) UnitGenerator.csv

if((Test-Path $destinationCsv) -eq $False)
{
	Copy-Item -Path ($sourceCsv) -Destination ($destinationCsv)
}

$sourceTt = Join-Path ($toolsPath) UnitGenerator.tt
$destinationTt = Join-Path ($projectPath) UnitGenerator.tt
if((Test-Path $destinationTt) -eq $False)
{
	(Get-Content ($sourceTt) -Raw) -Replace '%Namespace%', $namespace | Set-Content ($destinationTt)
}
