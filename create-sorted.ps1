$content = Get-Content -Encoding UTF8 ".\results\MultiReaderBench-report.csv"
$sorted = $content | ConvertFrom-Csv | Select-Object Method,Toolchain,TaskNum,Mean | Sort-Object Method,TaskNum,ToolChain
$sorted | Export-Csv -NoTypeInformation "results\MultiReaderBench-report-sorted.csv"

$content = Get-Content -Encoding UTF8 ".\results\MultiWriterBench-report.csv"
$sorted = $content | ConvertFrom-Csv | Select-Object Method,Toolchain,TaskNum,Mean | Sort-Object Method,TaskNum,ToolChain
$sorted | Export-Csv -NoTypeInformation "results\MultiWriterBench-report-sorted.csv"

$content = Get-Content -Encoding UTF8 ".\results\WhenAllBench-report.csv"
$sorted = $content | ConvertFrom-Csv | Select-Object Method,Toolchain,TaskNum,Mean | Sort-Object Method,TaskNum,ToolChain
$sorted | Export-Csv -NoTypeInformation "results\WhenAllBench-report-sorted.csv"
