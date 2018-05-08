<#
.SYNOPSIS
    Code Coverage percent verifier.
.DESCRIPTION
    Custom script that verifies the Code Coverage percent of a built project. By default the minimum acceptable is 80%.
.PARAMETER minimumAcceptableCodeCoveragePercent
	An integer that represents the minimum percentage of acceptable code coverage for succeed.
.NOTES
	File Name	: Check-CodeCoverage.ps1
	Author		: Fundacion Jala
#>
param(
    [int] $minimumAcceptableCodeCoveragePercent = 80
)
    
Write-Host "Minimum Acceptable Code Coverage is " -nonewline; Write-Host $minimumAcceptableCodeCoveragePercent -nonewline; Write-Host " %"

[Reflection.Assembly]::Load(“Microsoft.TeamFoundation.Client, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a”) | Out-Null 
[Reflection.Assembly]::Load(“Microsoft.TeamFoundation.TestManagement.Client, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a”) | Out-Null
[Reflection.Assembly]::Load(“Microsoft.TeamFoundation.TestManagement.Common, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a”) | Out-Null
[Reflection.Assembly]::Load("Microsoft.TeamFoundation.Build.Client,Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a”) | Out-Null

[string] $collectionUrl = "$env:SYSTEM_TEAMFOUNDATIONCOLLECTIONURI"
[string] $buildUrl = "$env:BUILD_BUILDURI"
[string] $project = "$env:SYSTEM_TEAMPROJECT"

[int] $coveredBlocks = 0
[int] $skippedBlocks = 0
[int] $totalBlocks = 0
[decimal] $codeCoveragePercent = 0
     
Start-Sleep -s 3

$teamProjectCollection = [Microsoft.TeamFoundation.Client.TfsTeamProjectCollectionFactory]::GetTeamProjectCollection($collectionUrl)
$testManagementService = $teamProjectCollection.GetService([Microsoft.TeamFoundation.TestManagement.Client.ITestManagementService])
$buildServer = $teamProjectCollection.GetService([Microsoft.TeamFoundation.Build.Client.IBuildServer])

[Microsoft.TeamFoundation.TestManagement.Client.ITestManagementTeamProject] $testManagementProject = $testManagementService.GetTeamProject($project);

$totalRuns = $testManagementProject.TestRuns.ByBuild($buildUrl)   

[Microsoft.TeamFoundation.TestManagement.Client.ICoverageAnalysisManager] $coverageAnalysisManager = $testManagementProject.CoverageAnalysisManager

foreach ($currentRun in $totalRuns)
{
    $sourceBlocks = $coverageAnalysisManager.QueryTestRunCoverage($currentRun.Id, 1)

    foreach ($currentBlock in $sourceBlocks)
    {
        $modules = $currentBlock.Modules

        foreach($module in $modules)
        {
            $coveredBlocks += $module.Statistics.BlocksCovered
            $skippedBlocks += $module.Statistics.BlocksNotCovered 
        }
    }
}

$totalBlocks = $coveredBlocks + $skippedBlocks;

if ($totalBlocks -eq 0)
{
    Write-Host "The current Code Coverage is 0.00 %. Failing the build."

    exit -1
}

$codeCoveragePercent = [math]::Round(($coveredBlocks * 100.00 / $totalBlocks), 2)

Write-Host "Total Code Coverage is " -nonewline; Write-Host $codeCoveragePercent -nonewline; Write-Host " %"

if ($codeCoveragePercent -lt $minimumAcceptableCodeCoveragePercent)
{
    Write-Host "Failing the build, minimum acceptable Code Coverage not met."
    exit -1
}

Write-Host "Required Code Coverage met."