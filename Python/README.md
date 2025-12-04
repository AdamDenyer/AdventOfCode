# Advent of Code: Python Solutions
These solutions currently run inside a Nix development shell, so either NixOS or the Nix package manager is required to run them "as-is". If you use a different type of Python environment, the list of required libraries in `shell.nix` could potentially be converted to a `requirements.txt` and used to set that up.
The shell is pinned to a specific nixpkgs commit for reproducibility of builds (similar to including version numbers in a `requirements.txt`). To use newer versions of Python and the required libraries, check for new commits at https://status.nixos.org and replace the commit ID in the URL in `shell.nix` with the one you wish to use (e.g. `https://github.com/NixOS/nixpkgs/archive/{commit-id}.tar.gz`).

## Setup
1. In the directory that contains `__main__.py` create a file called `.env`
1. Add the following contents to `.env`
```conf
REPO_PATH=/local/repo/directory/
INPUT_PATH=${REPO_PATH}Inputs/
EXAMPLE_FOLDER=Examples/
SLASH=/
```
1. Replace the value of `REPO_PATH` with the full local path to this repository's root directory (where the `Inputs` directory is found, along with the language-specific directories)
1. Replace the other values if required (mainly if the slashes need replacing based on your choice of OS)

## Run
1. Open a terminal in the directory that contains `shell.nix`
1. Run `nix-shell` to open the development shell (or `nix-shell --pure` if `nix-shell` by itself causes issues by trying to auto-run programs from the parent desktop session)
1. Run Python commands as usual. For example:
    - `python __main__.py` runs the whole project
    - `pytest` Runs all test definitions found within the project