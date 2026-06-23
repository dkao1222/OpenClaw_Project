# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity 6000.0.77f1。iOS-first，必須可在 iOS Simulator build 與 Xcode project 中測試；Android 和 WebGL 為後續 secondary target，但規劃與架構需保留多平台可能。
- monetization_direction: MVP 不強制付費牆。優先規劃 rewarded ads，例如復活、加倍獎勵、每日挑戰重試；interstitial ads 只能在局與局之間且需通過 UX/retention review；IAP 可包含 remove ads / cosmetic pack。AdMob 已可用，但實作需先保留安全開關與隱私合規。
- compatibility_target: iOS 15+，iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro；需考量 notch/dynamic island/safe area、不同解析度、觸控區大小、低階裝置效能。QA 至少要有 iOS simulator evidence，並規劃 Android 10+ representative devices 與 WebGL desktop browser 的後續兼容標準。
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
