mkdir tools
curl -fL -o tools/tailwindcss-linux-x64 https://github.com/tailwindlabs/tailwindcss/releases/download/$1/tailwindcss-linux-x64
curl -fL -o tools/tailwindcss-linux-arm64 https://github.com/tailwindlabs/tailwindcss/releases/download/$1/tailwindcss-linux-arm64
curl -fL -o tools/tailwindcss-macos-x64 https://github.com/tailwindlabs/tailwindcss/releases/download/$1/tailwindcss-macos-x64
curl -fL -o tools/tailwindcss-macos-arm64 https://github.com/tailwindlabs/tailwindcss/releases/download/$1/tailwindcss-macos-arm64
curl -fL -o tools/tailwindcss-windows-x64.exe https://github.com/tailwindlabs/tailwindcss/releases/download/$1/tailwindcss-windows-x64.exe