# Yet Another Amateur Advent of Code Repo
Personal solutions for the puzzles at https://adventofcode.com in multiple languages.

## C#
The `CSharp` directory contains the main `.sln` file and sub-directories for the `App` and `Tests` projects. 

### Setup
1. In the `App` directory that contains `App.csproj` create a file called `appsettings.json`
2. Add the following contents to `appsettings.json`
```json
{
    "Current": {
        "Year": "2015",
        "Day": "25",
        "RunAllDays": true
    },
    "Inputs": {
        "Examples": false,
        "Path" : {
            "Windows": "%UserProfile%\\dev\\AdventOfCode\\Inputs\\",
            "Linux": "%HOME%/dev/AdventOfCode/Inputs/"
        }
    },
    "OS": "Linux"
}
```
3. Replace the values of the settings as required
    - `Current:Year` must be a year with an existing class and namespace that are referenced in `Program.cs`
    - `Current:Day` must be a date with an existing class that is listed in the current year's class
    - `Current:RunAllDays` determines whether the app just runs the current day, or all days in the current year up to and including the current day
    - `Inputs:Examples` determines whether to use the example input files or the real ones
    - `Inputs:Path:{OS}` must contain the local path to this repository's `Inputs` directory
    - `OS` is the target operating system, and must match one of the names under `Inputs:Path`

### Run
1. Open a terminal in the directory that contains `CSharp.sln`
2. Run .NET commands as usual. For example:
    - `dotnet run --project .\App\` to run the main application
    - `dotnet test` to run all test definitions found within the solution

## Python
The solutions in the `Python` directory currently run inside a Nix development shell, so either NixOS or the Nix package manager is required to run them "as-is". A 'requirements.txt' file is included for compatibility with other Python environments, but the instructions below assume the usage of Nix.

The shell is pinned to a specific nixpkgs commit for reproducibility of builds (similar to including version numbers in `requirements.txt`). To use newer versions of Python and the required libraries, check for new commits at https://status.nixos.org and replace the relevant commit ID in the URL in `shell.nix` with the one you wish to use (i.e. `https://github.com/NixOS/nixpkgs/archive/{commit-id}.tar.gz`).

### Setup
1. In the `Python` directory that contains `__main__.py` create a file called `.env`
2. Add the following contents to `.env`
```conf
YEAR = 2015
DAY = 25
RUN_ALL = True
USE_EXAMPLES = False
REPO_PATH=/local/repo/directory/
INPUT_PATH=${REPO_PATH}Inputs/
EXAMPLE_DIR=Examples/
SLASH=/
```
3. Replace the values of the settings as required
    - `YEAR` and `DAY` must point to a date with a matching Python file (i.e. `{REPO_PATH}\Python\aoc{year}\day{day}.py`)
    - `RUN_ALL` determines whether `__main__.py` just runs the current day, or all days in the current year up to and including the current day
    - `USE_EXAMPLES` determines whether to use the example input files or the real ones
    - `REPO_PATH` must contain the local path to this repository's `Inputs` directory
    - `SLASH` sets which slash is used in filepaths and may need changing depending on the target OS

### Run
1. Open a terminal in the directory that contains `shell.nix`
2. Run `nix-shell` to open the development shell (or `nix-shell --pure` if `nix-shell` by itself causes issues by trying to auto-run programs from the parent desktop session)
3. Run Python commands as usual. For example:
    - `python __main__.py` runs the main application
    - `pytest` Runs all test definitions found within the `Python` directory and its subdirectories