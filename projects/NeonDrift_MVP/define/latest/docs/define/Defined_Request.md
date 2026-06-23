# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 388b9e33-8429-81e4-9c1c-db6d27675a52
- define_run_id: notion-NeonDrift_MVP-define-20260623142642
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

Build an iOS-first Unity mobile arcade drift game called NeonDrift. The player should understand the goal quickly, start a short run, steer left/right, chase score and mastery, avoid readable hazards, use boost/combo/wave objectives, fail with a clear reason, and retry immediately. The output must not be a plain flat background or a static block prototype; it needs planned gameplay depth, visual richness, and implementation-ready system design before development.

## Product Vision and Purpose（產品願景與目的）

這款 App 旨在驗證一個 iOS-first Unity 快節奏霓虹漂移遊戲 MVP。產品目標是讓玩家在 10 秒內理解玩法、30 秒內感受到技巧成長，並透過短局重試、combo、boost、wave objective、hazard pattern 形成可反覆遊玩的核心循環。

## Target Audience（目標受眾）

喜歡短局、街機、霓虹速度感、單手或雙手快速操作遊戲的手機玩家；也包含需要快速驗證 Unity iOS MVP pipeline 的開發/產品團隊。玩家可能只有零碎時間，因此需要立即開始、立即失敗原因、立即 retry。

## Core Value（核心價值）

1. 可讀且有深度的短局漂移核心循環。 2. 視覺華麗但不犧牲 iPhone 小螢幕可讀性。 3. planning/spec review 必須先定義系統規則、5W1H、VFX/asset/polish budget、QA acceptance，development 不可自行補設計債。

## Platform Target

Unity 6000.0.71f1, iOS-first, local iOS simulator build/QA first; Android and WebGL are secondary only after iOS path is stable.

## Monetization Direction

Rewarded ads first; interstitial ads only after retention and UX review. AdMob is available, but MVP gameplay and QA quality gates come first.

## Compatibility Target

iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro, Android 10+ representative devices, WebGL desktop browser as secondary.

## Output Expectation

Full pipeline outputs under workspace/<workspace_key>/<output_folder>/project/ and Git project folder. Notion-readable docs must include Game Quality Alignment and Game System Design Alignment where relevant. QA must include screenshots/recordings and structured checks for gameplay depth, visual richness, and game system design.

## Development Request

Start from Define and run the full OpenClaw game pipeline without Codex manually authoring agent deliverables. Define must normalize the request and pass to planning. Planning/spec review must use game_quality and game_system_design knowledge bases to specify gameplay depth, visual richness, system 5W1H, layer coverage, QA acceptance, and development readiness. Development should implement from spec review only. Build and QA should verify local Unity/iOS simulator evidence when available.
