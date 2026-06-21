# Stage 01 Context Pack

project_name: NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260621143447
channel_id: 386b9e33-8429-8189-8eaa-e181b7c82cc8

## project goal

NeonDrift MVP 是一款可快速迭代的 Unity 手機霓虹閃避遊戲，用短局高重玩性解決玩家碎片時間想快速進入、快速失敗、快速重試的需求。商業目標是建立可驗證的留存、廣告變現與跨平台發布基礎，先以 iOS simulator/local build 驗證，再擴展到 Android/WebGL。

## target audience

目標使用者是 13-35 歲喜歡 arcade、runner、reaction game 的手機玩家；常在通勤、排隊或短休息時間遊玩；痛點是多數手機遊戲開局太慢、廣告干擾太早、操作不夠即時。需要單手可玩、HUD 清楚、立即重試、低學習成本與穩定效能。

## core value

1. 單手左右 drift 操作立即有回饋。2. 60 FPS 目標下保持清楚 HUD、safe area、碰撞與重試流程。3. 支援廣告變現前置規劃，保留 rewarded ads 優先且不破壞短局節奏。

## locked decisions

- Notion watcher controls pipeline progression.
- Each downstream OpenClaw agent uses its configured model.
- Unity 6000.0.71f1 mobile direction is locked for planning.

## open questions

- Confirm final device compatibility and store policy details in downstream stages.

## next stage input policy

Read the Stage 01 handoff first, then this context pack. Open source paths only if details are missing.

## source paths

- /home/node/.openclaw/workspace/386b9e33-8429-81ba-ad07-da5d580a4b79/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260621144303/project/status/context/Initial_Request.md
- status/context/Project_Context_Index.md
- status/context/Current_Status_Summary.md
