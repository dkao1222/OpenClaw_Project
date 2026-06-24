# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260624122713
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260624122653

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：建立 NeonDrift_MVP，一款 iOS-first Unity 霓虹 arcade drifting 手機遊戲，用來完整驗證 OpenClaw pipeline。
需求必須從 Raw Idea 正規化到 Define，再進 Planning 0-12、Spec Review、Development、Local Unity iOS Simulator Build、QA、Delivery。
Planning 與 Spec Review 必須先規劃遊戲深度與畫面華麗度，不能到 development 才補。必須明確定義 icon、字體、背景、特效、音效、haptics、HUD、按鍵尺寸/位置/safe area、相容性機種與效能目標。
Development 必須產出 Unity 6000.0.77f1 專案，支援 iOS simulator，本機 Unity batchmode 可以 build，不需要人工開 Unity Hub。
QA 必須包含但不限於：按鍵是否可點、Start/Retry/Pause/Left/Right 功能、畫面是否可理解、遊戲物件是否有動態、玩家是否知道怎麼玩、早期 drift lost 是否合理、錄影/截圖/evidence、Unity Test Runner 結果。
Build row 應由 watcher/host runner 自動從 not start 開始，不需要人工改成 processing。
Define 階段需補齊痛點、服務目標、MVP 邊界與可驗證成功條件；若資訊不足，必須保留為 open questions。

## Target Audience（目標受眾）

由 Raw Idea 推導目標受眾；若原始想法未指定，先假設為 iOS 手機端使用者/玩家，並在 Define 階段標記需驗證。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；初始假設是操作/使用流程清楚、短時間可驗證、iOS 交付可測。

## Development Request

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea, infer only conservative assumptions, and mark unresolved items as open questions in Define outputs.
Raw idea type: game
Priority: high

Raw idea:
建立 NeonDrift_MVP，一款 iOS-first Unity 霓虹 arcade drifting 手機遊戲，用來完整驗證 OpenClaw pipeline。
需求必須從 Raw Idea 正規化到 Define，再進 Planning 0-12、Spec Review、Development、Local Unity iOS Simulator Build、QA、Delivery。
Planning 與 Spec Review 必須先規劃遊戲深度與畫面華麗度，不能到 development 才補。必須明確定義 icon、字體、背景、特效、音效、haptics、HUD、按鍵尺寸/位置/safe area、相容性機種與效能目標。
Development 必須產出 Unity 6000.0.77f1 專案，支援 iOS simulator，本機 Unity batchmode 可以 build，不需要人工開 Unity Hub。
QA 必須包含但不限於：按鍵是否可點、Start/Retry/Pause/Left/Right 功能、畫面是否可理解、遊戲物件是否有動態、玩家是否知道怎麼玩、早期 drift lost 是否合理、錄影/截圖/evidence、Unity Test Runner 結果。
Build row 應由 watcher/host runner 自動從 not start 開始，不需要人工改成 processing。

Raw idea source:
建立 NeonDrift_MVP，一款 iOS-first Unity 霓虹 arcade drifting 手機遊戲，用來完整驗證 OpenClaw pipeline。
需求必須從 Raw Idea 正規化到 Define，再進 Planning 0-12、Spec Review、Development、Local Unity iOS Simulator Build、QA、Delivery。
Planning 與 Spec Review 必須先規劃遊戲深度與畫面華麗度，不能到 development 才補。必須明確定義 icon、字體、背景、特效、音效、haptics、HUD、按鍵尺寸/位置/safe area、相容性機種與效能目標。
Development 必須產出 Unity 6000.0.77f1 專案，支援 iOS simulator，本機 Unity batchmode 可以 build，不需要人工開 Unity Hub。
QA 必須包含但不限於：按鍵是否可點、Start/Retry/Pause/Left/Right 功能、畫面是否可理解、遊戲物件是否有動態、玩家是否知道怎麼玩、早期 drift lost 是否合理、錄影/截圖/evidence、Unity Test Runner 結果。
Build row 應由 watcher/host runner 自動從 not start 開始，不需要人工改成 processing。

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260624122653
- define_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
- define_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- 
