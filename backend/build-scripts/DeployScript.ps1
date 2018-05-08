# DeployScript CBH
<# .SYNOPSIS
     Migration Script
.DESCRIPTION
     Execute the migrate.exe file in order to migrate the database at the machine
.NOTES
     Author: Jala Foundation
.LINK
     http://fundacion-jala.org/
.PARAMETER deployPath
Provide a PARAMETER section for the path where the necesary files are.
#>
param([String]$deployPath="./")
Try {
  Set-Location -Path $deployPath;
  ./migrate.exe JalaFoundation.Advantage.DataAccess.dll /startUpConfigurationFile=JalaFoundation.Advantage.DataAccess.dll.config -verbose
}
Catch {
  Write-Host "An error have Ocurred"
  exit -1
}