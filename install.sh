#!/bin/bash

# Set the project directory
PROJECT_DIR="src/Screen"

# Build the project
echo "Building the project..."
dotnet build $PROJECT_DIR

# Pack the project
echo "Packing the project..."
dotnet pack $PROJECT_DIR -o $PROJECT_DIR/nupkg

# Uninstall existing tool (if any)
echo "Uninstalling existing tool (if any)..."
dotnet tool uninstall --global wk.Screen

# Install the dotnet tool from the local project
echo "Installing the tool..."
dotnet tool install --global --add-source $PROJECT_DIR/nupkg wk.Screen

echo "wk.Screen tool has been built and installed globally."
