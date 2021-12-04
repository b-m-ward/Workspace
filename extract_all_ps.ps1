$zipFolder = {path}

$zipFiles = Get-ChildItem $zipFolder -Filter *.zip

foreach($zipFile in $zipFiles) {

    Write-Output $zipFile
}

foreach($zipFile in $zipFiles) {

    $zipOutPutFolderExtended = $zipFolder + "\" + $zipFile.BaseName
    Expand-Archive -Path $zipFile.FullName -DestinationPath $zipOutPutFolderExtended
    Write-Output 'EXTRACTED ' + $zipFile.FullName
}
