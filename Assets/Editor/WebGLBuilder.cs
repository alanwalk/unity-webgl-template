using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;

public static class WebGLBuilder
{
    private const string OutputPath = "Builds/WebGL";

    [MenuItem("Build/Build WebGL")]
    public static void Build()
    {
        Directory.CreateDirectory(OutputPath);

        EditorUserBuildSettings.SwitchActiveBuildTarget(
            BuildTargetGroup.WebGL,
            BuildTarget.WebGL);

        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Gzip;
        PlayerSettings.WebGL.decompressionFallback = true;

        string[] scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();

        if (scenes.Length < 1)
        {
            throw new InvalidOperationException("No enabled scenes found in EditorBuildSettings.");
        }

        var options = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = OutputPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(options);
        if (report.summary.result != BuildResult.Succeeded)
        {
            throw new InvalidOperationException(
                $"WebGL build failed: {report.summary.result}, errors: {report.summary.totalErrors}");
        }
    }
}
