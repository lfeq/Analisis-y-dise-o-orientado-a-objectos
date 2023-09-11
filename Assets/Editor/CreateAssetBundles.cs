using UnityEditor;

public class CreateAssetBundles {

    [MenuItem("Assets/Build AssetBundles")]
    private static void BuildAllAssetBundles() {
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}