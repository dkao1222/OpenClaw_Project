# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 388b9e33-8429-8102-a291-e3e15007a022
- define_run_id: notion-NeonDrift_MVP-define-20260623172212
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

從頭測試 OpenClaw game pipeline：由 Define 正規化需求，接續 Planning、Spec Review、Development、Build、QA。產品是 iOS-first Unity 快節奏霓虹漂移遊戲 NeonDrift MVP。需要避免單調、黑屏、看不懂怎麼玩、按鍵無效、畫面不動、沒有遊戲目標等問題。需要在 planning/spec review 階段就明確規劃遊戲深度、視覺華麗度、操作回饋、UI icon/字體/背景/VFX/audio/haptics、功能 QA 與人類感官驗證。Build 使用 Unity 6000.0.77f1，本機 host runner 自動處理 iOS simulator build 與 QA。

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP 是一款 iOS-first 的短局霓虹漂移遊戲，用 30-90 秒一局驗證手機端快速反應、左右漂移、風險回饋與重試循環。它要解決快遊戲原型常見的問題：玩法說不清、畫面空、按鈕不可用、失敗原因不明、沒有視覺回饋、QA 只看檔案不看真實體驗。商業目標是建立可用於 Apple App Store / Google Play 後續擴展的 MVP pipeline，初期收益方向以 rewarded ads 和可選付費去廣告為主。

## Target Audience（目標受眾）

主要玩家是 13-35 歲喜歡短局、霓虹速度感、反覆挑戰高分的手機玩家；包含通勤、休息時間、短影音切換間隙想玩 1 分鐘遊戲的人。次要受眾是使用 OpenClaw 驗證 game planning-to-build pipeline 的開發者，需要能在 Notion、Git、Unity simulator 中看到可檢查、可重跑、可 QA 的交付結果。玩家痛點是新手不知道要做什麼、按了沒反應、畫面單調、失敗太突然、缺少爽感與成長感。

## Core Value（核心價值）

1. 一眼看懂且立即可玩的 drift loop：清楚 Start/Retry、左右漂移、分數/Pulse/危險回饋。 2. 華麗但可讀的霓虹視覺與感官回饋：背景移動、跑道、玩家方塊、障礙/收集物、粒子、音效、haptics 都要有明確規格。 3. 可驗證的 pipeline 交付：planning/spec review 必須先定義遊戲深度、視覺標準、QA gates；development/build/QA 不能只補最低可執行版本。

## Platform Target

Unity 6000.0.77f1。iOS-first，必須可在 iOS Simulator build 與 Xcode project 中測試；Android 和 WebGL 為後續 secondary target，但規劃與架構需保留多平台可能。

## Monetization Direction

MVP 不強制付費牆。優先規劃 rewarded ads，例如復活、加倍獎勵、每日挑戰重試；interstitial ads 只能在局與局之間且需通過 UX/retention review；IAP 可包含 remove ads / cosmetic pack。AdMob 已可用，但實作需先保留安全開關與隱私合規。

## Compatibility Target

iOS 15+，iPhone SE 2/3、iPhone 12/13 mini、iPhone 15/15 Pro；需考量 notch/dynamic island/safe area、不同解析度、觸控區大小、低階裝置效能。QA 至少要有 iOS simulator evidence，並規劃 Android 10+ representative devices 與 WebGL desktop browser 的後續兼容標準。

## Output Expectation

Define 必須產出 canonical request。Planning 必須分階段輸出細化文件，包括遊戲系統深度、UX flow、prototype/canvas flow、visual/audio/haptics、icon/font/background/VFX 規格與 compatibility gates。Spec Review 必須檢查文件是否足以開發，不接受籠統描述。Development 必須產出 Unity project、資產、腳本、測試、QA probe。Build 必須用 local Unity 6000.0.77f1 產生 iOS simulator 可啟動結果。QA 必須包含功能測試、按鍵測試、遊戲目標可理解性、畫面動態、失敗/重試流程、錄影/截圖 evidence、人類感官 review gate，通過後同步 Notion 與 Git。

## Development Request

Run the full OpenClaw game pipeline from Define to Planning, Spec Review, Development, Build, and QA without Codex hand-authoring deliverables. Each local/OpenClaw agent must use its configured model. Output must be bounded, richly detailed, Notion-readable, Git-published, and suitable for Unity iOS simulator validation. QA must include button interaction, gameplay function, visual motion, readable objective, retry/start flow, recording/screenshot evidence, and human-sensory review gates.
