# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity 6000.0.71f1, iOS-first, Android and WebGL as secondary targets, local Unity build only.
- monetization_direction: Rewarded ads first using AdMob; interstitial ads only after retention and user experience review; privacy and store disclosures required.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, Android 10+ representative devices, and WebGL desktop browser.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
