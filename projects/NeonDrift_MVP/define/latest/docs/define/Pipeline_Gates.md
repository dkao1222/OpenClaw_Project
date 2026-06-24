# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build rows stay not start until user confirms Unity Hub, license, and editor readiness.

## Locked Decisions

- platform_target: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- monetization_direction: Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。
- compatibility_target: iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed
