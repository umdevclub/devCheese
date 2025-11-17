# devCheese: Cheese Chase Recreation in Unity
Mimi the mouse is hungry and stuck in a maze. Help her find the cheese but void the evil beetles (int implemented). And watch out for ghosts—the maze is haunted (also not implemented)!

## Unity Project Setup: Quick Guide
This guide covers the necessary steps to clone the repository and open the Unity project.

### 1. Prerequisites
Ensure you have these tools installed:
- Git & Git LFS: Required for cloning and downloading large binary assets (models, textures) specific to Unity projects.
- Unity Editor: You must have the project's specific Unity version installed (check ProjectSettings/ProjectVersion.txt).

### 2. Downloading and Cloning the Repository
You have three main options for getting the project files onto your local machine.

### Option A: Downloading the ZIP File (Simple Download)
1. Go to the main repository page on GitHub.
2. Click the green Code button.
3. Select Download ZIP.
4. Unzip the downloaded file to your desired project location.

Warning: This method may not download Git LFS files correctly. If assets are missing, use Option B.

### Option B: Cloning via Git (Recommended)
1. Navigate to your target directory and clone the project:
```
git clone https://github.com/tastyphil/devCheese.git
```
2. If large assets (LFS files) are missing after cloning, run:
```
git lfs pull
```
### Option C: Cloning via GitHub Desktop
1. In GitHub Desktop, choose File > Clone Repository.
2. Select the repository, choose the local path, and click Clone.

## 3. Opening the Project in Unity Hub
1. Open the Unity Hub.
2. Click "Add" and select the root folder of the cloned repository (the folder containing the Assets folder).
3. Click "Add Project".
4. Select the project entry to open it in the correct Unity Editor version.

Note: The initial import in the Editor will take a few minutes as Unity compiles the assets.
