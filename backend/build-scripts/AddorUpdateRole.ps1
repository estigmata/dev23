# AddorUpdateRole CBH
<# .SYNOPSIS
     Add or Update Role Script
.DESCRIPTION
     Execute the AddorUpdateRole.sql file in order to create a role or update it if exists
.NOTES
     Author: Jala Foundation
.LINK
     http://fundacion-jala.org/
.PARAMETER sqlPath
Provide a PARAMETER section for the path where the necesary files are.
.PARAMETER database
Provide a PARAMETER section for set the name of Database.
.PARAMETER name
Provide a PARAMETER section for the name of the role that we look to insert or update.
.PARAMETER url
Provide a PARAMETER section for the name of the url that we look to insert or update.
#>
param([String]$sqlPath="./",
[String]$database="./",
[String]$name="./",
[String]$url="./")
Try {
  Set-Location -Path $sqlPath;
  sqlcmd -i AddUpdateRole.sql -v database=$database roleName=$name roleUrl=$url -E
}
Catch {
  Write-Host $_.Exception.Message
  exit -1
}