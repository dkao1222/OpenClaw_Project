# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 388b9e33-8429-8124-8fa0-d8813b99be12
- define_run_id: notion-NeonDrift_MVP-define-20260623174619
- agent_model_policy: per-agent-config
- thinking: off

## Raw Idea（原始想法）

重跑 NeonDrift MVP 全流程。目標是驗證 OpenClaw Notion pipeline 可以從 Define 自動推進到 Planning、Spec Review、Development、Build、QA。遊戲是 iOS-first Unity 快節奏 neon drift arcade，不能只有空背景與按鈕，必須有可理解的核心玩法、視覺華麗度、遊戲深度、明確目標、障礙、分數、失敗/重試、暫停、觸控控制、icon、字體、背景、特效與音效/震動規劃。Build 必須使用本機 Unity 6000.0.77f1 自動 batchmode build，不需要手動改 Build row 狀態。QA 必須包含按鍵位置/大小/可點擊性、safe area、遊戲功能、runtime evidence、非空白畫面、可理解性與交付文件。

## Product Vision and Purpose（產品願景與目的）

建立一個可在 iOS simulator 本機 build 並可 QA 驗證的 NeonDrift MVP，驗證 OpenClaw 可以把手機端/Notion 的需求轉成規劃、規格、Unity 專案、build、QA 與交付證據。

## Target Audience（目標受眾）

喜歡短局、單手操作、霓虹視覺、快速重試 arcade 遊戲的手機玩家；也服務於需要快速驗證 game pipeline 的獨立開發者。

## Core Value（核心價值）

1. 一眼能懂的 drift 操作與立即重試。 2. 有視覺層次、特效、音效/震動與清楚 HUD 的短局體驗。 3. 全流程可追蹤：Notion、Git、Unity build、QA evidence 與 delivery manifest。

## Platform Target

Unity 6000.0.77f1, iOS simulator/local build first; Android and WebGL remain secondary follow-up targets.

## Monetization Direction

AdMob rewarded ads first, no intrusive interstitials before retention and UX review; privacy and store readiness must be documented.

## Compatibility Target

iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro simulator/device class; safe area and aspect ratio must be checked.

## Output Expectation

Every stage must output bounded, detailed, Notion-readable Markdown/JSON evidence. Planning/spec must define visual richness and game depth before development. Build and QA must pass with 0 failed/blocked.

## Development Request

Run full game pipeline from Define through QA. Do not require manual Build status changes. The generated build row must include auto_build_allowed: true and host watcher must start the local Unity build from not start when Unity 6000.0.77f1 is available.
