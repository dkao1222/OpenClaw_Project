# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260625052803
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260625052752

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts.
Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame.
Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.
Define 階段需補齊痛點、服務目標、MVP 邊界與可驗證成功條件；若資訊不足，必須保留為 open questions。

## Target Audience（目標受眾）

由 Raw Idea 推導目標受眾；若原始想法未指定，先假設為 iOS 手機端使用者/玩家，並在 Define 階段標記需驗證。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；初始假設是操作/使用流程清楚、短時間可驗證、iOS 交付可測。

## Development Request

Product Experience Contract from Define.
Required markers: game design foundation, core mechanics, game loop, systems and tuning, level design, game terminology, term table, user-centric reverse deduction, MDA, vision lock, content architecture, player journey, shipping plan, human playability, visual richness, retry, after-retry visual delta, audio feedback, evidence contract.
Required game-quality markers: moment-to-moment gameplay, 10-second playability timeline, encounter pattern, enemy pattern, player skill, risk reward, feedback event, human playtest.
Planning must read docs/define/Defined_Request.md, docs/define/Project_Input_Schema.md, docs/define/Pipeline_Gates.md, and handoffs/define/handoff_to_planning.md for full bounded context.

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea, infer only conservative assumptions, and mark unresolved items as open questions in Define outputs.
Raw idea type: game
Priority: high

Raw idea:
Create an iOS-first Unity quick game MVP named NeonDrift_MVP.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts.
Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame.
Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity
