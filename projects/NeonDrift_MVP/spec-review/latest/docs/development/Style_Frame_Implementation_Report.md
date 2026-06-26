# Style Frame Implementation Report

## 繁體中文

- project: NeonDrift_MVP
- style frame implementation source: docs/design/Style_Frames.md, docs/design/Art_Asset_Implementation_Matrix.md, docs/design/Visual_Target_Lock.md, docs/review/Visual_Style_Frame_Readiness.md
- Unity implementation must not rely on flat background or static blocks only; visible player/threat/reward/failure/retry identity is required.

| Style frame | Unity screen state | Required visible asset usage | QA evidence |
| --- | --- | --- | --- |
| main menu | Menu | title, Start CTA, Settings, Best Score | ios_simulator_menu.png |
| gameplay | Running | track, player vehicle, hazard shard, HUD score/pulse | ios_simulator_gameplay.png |
| reward/boost | RunningReward | boost cell, combo pulse, reward color, score tick | ios_simulator_gameplay.png |
| danger/near miss | RunningDanger | hazard warning, near-miss streak, danger color | ios_simulator_gameplay.png |
| failure/game-over | Failure | failure flash, reason text, retry CTA | ios_simulator_game_over.png |
| retry result | RetryTransition | retry surge, fresh run visual delta | ios_simulator_after_retry.png |

## English

- The six style frames must map to Unity screen states and QA evidence.
- QA must compare video/screenshots against this report; missing visual delta blocks release.

## Acceptance

- style frame implementation: required
- asset usage in Unity: required
- visual delta across main menu, gameplay, reward, danger, failure, and retry: required
- QA screenshot/video evidence: required
