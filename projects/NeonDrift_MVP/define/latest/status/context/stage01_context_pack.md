# Stage 01 Context Pack

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644

## project goal

這款 App 旨在驗證一個 iOS-first Unity 快節奏霓虹漂移遊戲 MVP。產品目標是讓玩家在 10 秒內理解玩法、30 秒內感受到技巧成長，並透過短局重試、combo、boost、wave objective、hazard pattern 形成可反覆遊玩的核心循環。

## target audience

喜歡短局、街機、霓虹速度感、單手或雙手快速操作遊戲的手機玩家；也包含需要快速驗證 Unity iOS MVP pipeline 的開發/產品團隊。玩家可能只有零碎時間，因此需要立即開始、立即失敗原因、立即 retry。

## core value

1. 可讀且有深度的短局漂移核心循環。 2. 視覺華麗但不犧牲 iPhone 小螢幕可讀性。 3. planning/spec review 必須先定義系統規則、5W1H、VFX/asset/polish budget、QA acceptance，development 不可自行補設計債。

## locked decisions

- Notion watcher controls pipeline progression.
- Each downstream OpenClaw agent uses its configured model.
- Unity 6000.0.71f1 mobile direction is locked for planning.

## open questions

- Confirm final device compatibility and store policy details in downstream stages.

## next stage input policy

Read the Stage 01 handoff first, then this context pack. Open source paths only if details are missing.

## source paths

- /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/Initial_Request.md
- status/context/Project_Context_Index.md
- status/context/Current_Status_Summary.md
