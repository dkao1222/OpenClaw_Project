# Project Context Index

project_name: NeonDrift_MVP
channel_id: 382b9e3384298039b171c9b2a60ae644
source_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/status/context/Initial_Request.md

## Product Vision and Purpose

- snippet: NeonDrift MVP 是一款 iOS-first 的短局霓虹漂移遊戲，用 30-90 秒一局驗證手機端快速反應、左右漂移、風險回饋與重試循環。它要解決快遊戲原型常見的問題：玩法說不清、畫面空、按鈕不可用、失敗原因不明、沒有視覺回饋、QA 只看檔案不看真實體驗。商業目標是建立可用於 Apple App Store / Google Play 後續擴展的 MVP pipeline，初期收益方向以 rewarded ads 和可選付費去廣告為主。

## Target Audience

- snippet: 主要玩家是 13-35 歲喜歡短局、霓虹速度感、反覆挑戰高分的手機玩家；包含通勤、休息時間、短影音切換間隙想玩 1 分鐘遊戲的人。次要受眾是使用 OpenClaw 驗證 game planning-to-build pipeline 的開發者，需要能在 Notion、Git、Unity simulator 中看到可檢查、可重跑、可 QA 的交付結果。玩家痛點是新手不知道要做什麼、按了沒反應、畫面單調、失敗太突然、缺少爽感與成長感。

## Core Value

- snippet: 1. 一眼看懂且立即可玩的 drift loop：清楚 Start/Retry、左右漂移、分數/Pulse/危險回饋。 2. 華麗但可讀的霓虹視覺與感官回饋：背景移動、跑道、玩家方塊、障礙/收集物、粒子、音效、haptics 都要有明確規格。 3. 可驗證的 pipeline 交付：planning/spec review 必須先定義遊戲深度、視覺標準、QA gates；development/build/QA 不能只補最低可執行版本。

## Development Request

- snippet: Run the full OpenClaw game pipeline from Define to Planning, Spec Review, Development, Build, and QA without Codex hand-authoring deliverables. Each local/OpenClaw agent must use its configured model. Output must be bounded, richly detailed, Notion-readable, Git-published, and suitable for Unity iOS simulator validation. QA must include button interaction, gameplay function, visual motion, readable objective, retry/s
