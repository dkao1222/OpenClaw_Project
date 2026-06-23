# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity 6000.0.77f1, iOS simulator first, iOS device/App Store later, Android and WebGL secondary.
- monetization_direction: Rewarded ads first; interstitial ads only after retention and user experience review. AdMob account is available.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro; safe-area, touch targets, reduced motion, and readable contrast required.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
