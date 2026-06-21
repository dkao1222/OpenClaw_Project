# Build Run Instructions

## 繁體中文

- 使用 Unity Hub 安裝 Unity Editor 後，開啟 `unity/NeonDrift` 專案。
- 可用 Unity batchmode 執行 `BuildPipelineRunner.BuildIOS`、`BuildAndroid`、`BuildWebGL` 產出 iOS、Android、WebGL build。
- App icon assets 必須已存在：`unity/NeonDrift/Assets/Branding/AppIcon.png`、iOS icon set、Android adaptive icon、WebGL favicon 與 `assets/icons/app_icon_manifest.json`。
- Visual assets 必須已存在：bitmap font atlas、neon track background、VFX spritesheet、typography/background/VFX manifests 與 `status/validation/visual_assets_validation.md`。
- Compatibility Matrix build check: iOS 15+ / iPhone SE 2/3 / iPhone 12/13 mini / iPhone 15/15 Pro 為主要驗收；Android 10+ 代表機與 WebGL desktop browser 為次要驗證；每次 build report 必須記錄 aspect ratio 與 performance budget。

## English

- Install Unity Editor through Unity Hub, then open the `unity/NeonDrift` project.
- Use Unity batchmode with `BuildPipelineRunner.BuildIOS`, `BuildAndroid`, or `BuildWebGL` to produce iOS, Android, and WebGL builds.
- App icon assets must exist: `unity/NeonDrift/Assets/Branding/AppIcon.png`, iOS icon set, Android adaptive icon, WebGL favicon, and `assets/icons/app_icon_manifest.json`.
- Visual assets must exist: bitmap font atlas, neon track background, VFX spritesheet, typography/background/VFX manifests, and `status/validation/visual_assets_validation.md`.
- Compatibility Matrix build check: iOS 15+ / iPhone SE 2/3 / iPhone 12/13 mini / iPhone 15/15 Pro are primary acceptance targets; representative Android 10+ devices and WebGL desktop browsers are secondary checks; each build report must record aspect ratio and performance budget.
