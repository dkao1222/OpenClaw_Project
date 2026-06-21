# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260621165055
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260621165046

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：建立一個 iOS first 的 Unity 手機遊戲 MVP，名稱 NeonDrift_MVP。
核心是短局霓虹漂移/閃避操作，玩家用手機觸控控制飛行器或光軌在高可讀性的賽道中生存、收集、累積分數。
需要從 raw idea 經 define、planning、spec review、development、local build、QA。
設計要考慮 iOS Human Interface Guidelines、icon、字體、背景、特效、相容機種、廣告收益但不能破壞核心體驗。
最終交付要包含 Unity 專案、iOS simulator 可測 build、QA 報告、交付文件與 Notion 可讀文件。
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
建立一個 iOS first 的 Unity 手機遊戲 MVP，名稱 NeonDrift_MVP。
核心是短局霓虹漂移/閃避操作，玩家用手機觸控控制飛行器或光軌在高可讀性的賽道中生存、收集、累積分數。
需要從 raw idea 經 define、planning、spec review、development、local build、QA。
設計要考慮 iOS Human Interface Guidelines、icon、字體、背景、特效、相容機種、廣告收益但不能破壞核心體驗。
最終交付要包含 Unity 專案、iOS simulator 可測 build、QA 報告、交付文件與 Notion 可讀文件。

Raw idea source:
建立一個 iOS first 的 Unity 手機遊戲 MVP，名稱 NeonDrift_MVP。
核心是短局霓虹漂移/閃避操作，玩家用手機觸控控制飛行器或光軌在高可讀性的賽道中生存、收集、累積分數。
需要從 raw idea 經 define、planning、spec review、development、local build、QA。
設計要考慮 iOS Human Interface Guidelines、icon、字體、背景、特效、相容機種、廣告收益但不能破壞核心體驗。
最終交付要包含 Unity 專案、iOS simulator 可測 build、QA 報告、交付文件與 Notion 可讀文件。

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260621165046
- define_output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
- define_handoff_path: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- monetization_direction: Raw Idea 未明確指定時，不預設付費牆；若是遊戲，先保留 rewarded ads 優先且不得破壞核心體驗，並由 Define/Spec Review 細化。
- compatibility_target: iOS first: current iOS simulator/local build gate. Device targets and OS floor must be refined by Define/Spec Review.
- output_expectation: Define must produce canonical fields, open questions, bounded planning handoff, Notion-readable docs, and downstream-ready Planning input.
