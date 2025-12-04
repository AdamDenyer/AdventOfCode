let
  pkgs = import (fetchTarball "https://github.com/NixOS/nixpkgs/archive/1aab89277eb2d87823d5b69bae631a2496cff57a.tar.gz") {};
  # Nixpkgs version last updated: 2025-12-02
in pkgs.mkShell {
  packages = [
    (pkgs.python3.withPackages (python-pkgs: with python-pkgs; [
      colorama
      iniconfig
      numpy
      packaging
      pluggy
      pytest
      python-dotenv
    ]))
  ];
}