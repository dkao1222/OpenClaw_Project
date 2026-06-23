# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260623175815
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260623174619:retry-after-disk-cleanup

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

建立一個可在 iOS simulator 本機 build 並可 QA 驗證的 NeonDrift MVP，驗證 OpenClaw 可以把手機端/Notion 的需求轉成規劃、規格、Unity 專案、build、QA 與交付證據。

## Target Audience（目標受眾）

喜歡短局、單手操作、霓虹視覺、快速重試 arcade 遊戲的手機玩家；也服務於需要快速驗證 game pipeline 的獨立開發者。

## Core Value（核心價值）

1. 一眼能懂的 drift 操作與立即重試。 2. 有視覺層次、特效、音效/震動與清楚 HUD 的短局體驗。 3. 全流程可追蹤：Notion、Git、Unity build、QA evidence 與 delivery manifest。

## Development Request

Run full game planning from Define output. Requirements: iOS-first Unity 6000.0.77f1, auto Build later, visual richness planned before development, game depth planned before development, QA evidence for buttons and gameplay, Notion/Git delivery. Build must auto-start from not start when auto_build_allowed is present; do not require manual Build status change downstream.
