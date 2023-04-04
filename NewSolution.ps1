Param(
    [Parameter(Position = 0, Mandatory=$true)]
    [Int32]$ProblemNumber,
    [Parameter(Position = 1, Mandatory=$true)]
    [String]$SlnReturnType,
    [Parameter(Position = 2, Mandatory=$true)]
    [String]$SlnMethodName,
    [Parameter(Position = 3, Mandatory=$true)]
    [String]$SlnParameters
)

$splitedParameters = $SlnParameters.Split(",");
$parametersType = @();
$parametersName = @();
Foreach($p in $splitedParameters)
{
    $parametersType += $p.Trim().Split(" ")[0].Trim();
    $parametersName += $p.Trim().Split(" ")[1].Trim();
}


$SolutionMethodSignature = [String]::Format("public {0} {1}({2})", $SlnReturnType, $SlnMethodName, $SlnParameters);

$ProblemNumberWithPadding = ([String]$ProblemNumber).PadLeft(4, '0');

$rootPath = Split-Path $MyInvocation.MyCommand.Path -Parent;

$solutionFolderPath = Join-Path $rootPath LeetCodeSolutions Solutions $("_" + $ProblemNumberWithPadding);
$solutionFilePath = Join-Path $solutionFolderPath Solution.cs;
$testFolderPath = Join-Path $rootPath LeetCodeTests SolutionsTest $("_" + $ProblemNumberWithPadding);
$testFilePath = Join-Path $testFolderPath SolutionTest.cs;


$solutionFileTemplate = @"
using System;
using System.Collections.Generic;
using System.Linq;

using LeetCodeSolutions.Definitions;

namespace LeetCodeSolutions.Solutions._{0};

public class Solution
{{
    {1}
    {{
        throw new NotImplementedException();
    }}
}}
"@;
$solutionFileContent = [string]::Format($solutionFileTemplate, $ProblemNumberWithPadding, $SolutionMethodSignature);

$testFileTemplate = @"
using LeetCodeSolutions.Definitions;
using LeetCodeSolutions.Solutions._{0};
using LeetCodeTests.TestHelper;
using Xunit;

namespace LeetCodeTests.SolutionsTest._{0};

public class SolutionTest
{{
    [Theory]
    /*[InlineData]() */
    public void {1}Test({2}, {3} expected)
    {{
        {3} actual = new Solution().{1}({4});
        Assert.Equal(
            expected: expected,
            actual: actual,
            comparer: /*TODO*/);
    }}
}}
"@;
$testFileContent = [string]::Format($testFileTemplate, $ProblemNumberWithPadding, $SlnMethodName, $SlnParameters, $SlnReturnType, [string]::Join(", ", $parametersName))

New-Item -ItemType Directory -Force -Path $solutionFolderPath;
New-Item -ItemType Directory -Force -Path $testFolderPath;
Set-Content -Path $solutionFilePath -Value $solutionFileContent;
Set-Content -Path $testFilePath -Value $testFileContent;