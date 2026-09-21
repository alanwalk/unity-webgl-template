# Unity WebGL Template

Unity **2022.3.62f3** WebGL template project with a GitHub Actions build.

## Open locally

1. Install Unity 2022.3.62f3 with the WebGL Build Support module.
2. Open this repository from Unity Hub.
3. Open `Assets/Scenes/Main.unity`.
4. Use **Build > Build WebGL** or switch the active platform to WebGL in Build Settings.

Local builds are written to `Builds/WebGL`.

## GitHub Actions

The workflow runs on pushes to `main` and via manual dispatch. It uploads `Builds/WebGL` as the `WebGL` artifact for 14 days.

For a Unity Personal license, add these repository Actions secrets:

- `UNITY_LICENSE`: complete contents of the activated `.ulf` file
- `UNITY_EMAIL`: Unity account email
- `UNITY_PASSWORD`: Unity account password

Then open **Actions > Build WebGL > Run workflow**. The generated site is available from the run's **Artifacts** section.
