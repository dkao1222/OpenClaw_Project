# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity 6000.0.77f1, iOS simulator/local build first; Android and WebGL remain secondary follow-up targets.
- monetization_direction: AdMob rewarded ads first, no intrusive interstitials before retention and UX review; privacy and store readiness must be documented.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro simulator/device class; safe area and aspect ratio must be checked.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
