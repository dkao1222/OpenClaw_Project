# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 386b9e33-8429-8199-abd2-fcb1304fc85c
- define_run_id: notion-NeonDrift_MVP-define-20260621150007
- agent_model_policy: per-agent-config
- thinking: off

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP 是一款可快速迭代的 Unity 手機霓虹閃避遊戲，用短局高重玩性解決玩家碎片時間想快速進入、快速失敗、快速重試的需求。商業目標是建立可驗證的留存、廣告變現與跨平台發布基礎，先以 iOS simulator/local build 驗證，再擴展到 Android/WebGL。

## Target Audience（目標受眾）

目標使用者是 13-35 歲喜歡 arcade、runner、reaction game 的手機玩家；常在通勤、排隊或短休息時間遊玩；痛點是多數手機遊戲開局太慢、廣告干擾太早、操作不夠即時。需要單手可玩、HUD 清楚、立即重試、低學習成本與穩定效能。

## Core Value（核心價值）

1. 單手左右 drift 操作立即有回饋。2. 60 FPS 目標下保持清楚 HUD、safe area、碰撞與重試流程。3. 支援廣告變現前置規劃，保留 rewarded ads 優先且不破壞短局節奏。

## Platform Target

Unity 6000.0.71f1 preferred, compatible Unity 6000 LTS local editor allowed when project imports and build validation passes; iOS-first, Android and WebGL as secondary targets.

## Monetization Direction

Rewarded ads first; interstitial ads only after retention and user experience review. AdMob account is available.

## Compatibility Target

iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, Android 10+ representative devices, WebGL desktop browser.

## Output Expectation

Planning must produce bounded Markdown handoffs, Notion-readable documents, Git publish output, downstream-ready spec review and development handoffs, local Unity build evidence, and deterministic QA result files.

## Development Request

Restart the full pipeline from Define through Planning, Spec Review, Development, local Unity Build, and QA. Do not manually edit agent outputs during the run. Use pipeline validators, deterministic context compression, local Unity build evidence, and deterministic QA finalizer.
