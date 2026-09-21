# Unity WebGL Template

Unity **2022.3.62f3** WebGL template project with a GitHub Actions build.

## Open locally

1. Install Unity 2022.3.62f3 with the WebGL Build Support module.
2. Open this repository from Unity Hub.
3. Open `Assets/Scenes/Main.unity`.
4. Use **Build > Build WebGL** or switch the active platform to WebGL in Build Settings.

Local builds are written to `Builds/WebGL`.

## GitHub Actions

The workflow runs on pushes to `main` and via manual dispatch. It uploads `Builds/WebGL` as the `WebGL` artifact.

Add a repository Actions secret named `UNITY_LICENSE` containing your activated Unity license file content before running the workflow.
