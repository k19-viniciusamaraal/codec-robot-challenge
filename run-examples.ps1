$fileName = 'test-arguments.txt';
$exeName = 'src\CodecRobotChallenge\bin\Release\netcoreapp3.1\CodecRobotChallenge.exe';

dotnet build --configuration Release

foreach($line in Get-Content .\$fileName) {
	Start-Process -NoNewWindow -FilePath .\$exeName @($line) -Wait;
	
	echo 'Fim da linha ' + $line;
}