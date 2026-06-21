# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity 6000 LTS family, iOS simulator and iOS device first, Android and WebGL secondary. Local Unity build is required; Unity Cloud Build is not used.
- monetization_direction: Rewarded ads first through AdMob; interstitial ads only after UX and retention review. Apple Developer and AdMob accounts are available. Privacy, ATT, Google Play Data Safety, and App Store privacy labels must be considered.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro including notch/Dynamic Island safe area, Android 10+ representative devices, and WebGL desktop browser.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
