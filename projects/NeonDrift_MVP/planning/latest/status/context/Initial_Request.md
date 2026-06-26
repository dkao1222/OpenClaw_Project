# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260626163755
chain_id: raw:NeonDrift_MVP:20260626163656
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260626163746

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score.
The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts.
Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame.
Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.
遊戲概念：Neon arcade drift runner: the player pilots a glowing hover car in a moving light tunnel, making quick left/right drift decisions under pressure.
玩家目標：Survive the run, avoid hazard shards, collect boost cells, chain near misses/combo score, and beat the best score with fast retry.
必須包含：Start menu, Settings/Sound, best score, left/right touch controls, moving player vehicle, track/background motion, hazards, boost

## Target Audience（目標受眾）

由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。
核心玩法：Tap/hold left or right to drift between lanes while the track scrolls. Hazards damage/end the run, boosts restore pulse and score, and retry must restart a fresh moving run.
核心物件：Player hover car, neon track/lane rails, hazard shards, boost cells, score/combo/pulse HUD, pause, failure overlay with reason, retry button.
視覺方向：High-contrast neon arcade style with moving background layers, visible vehicle silhouette, cyan/magenta hazard-reward language, glow trails, readable HUD, and safe-area aware controls.
成功條件：QA must provide screenshots/video proving Start, moving gameplay, left/right control response, hazard, boost, score/pulse change, failure reason, retry reset, visual richness, and non-placeholder style frames.
QA 要求：QA must include simulator screenshots, playthrough video, touch/button checks, every gameplay function check, human visual readability, product experience, style-frame evidence, retry recovery, and build artifacts.

## Development Request

Product Experience Contract from Define.
Required markers: game design foundation, core mechanics, game loop, systems and tuning, level design, game terminology, term table, user-centric reverse deduction, MDA, vision lock, content architecture, player journey, shipping plan, human playability, visual richness, retry, after-retry visual delta, audio feedback, evidence contract.
Required game-quality markers: moment-to-moment gameplay, 10-second playability timeline, encounter pattern, enemy pattern, player skill, risk reward, feedback event, human playtest.
Planning must read docs/define/Defined_Request.md, docs/define/Project_Input_Schema.md, docs/define/Pipeline_Gates.md, and handoffs/define/handoff_to_planning.md for full bounded context.

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea. Do not invent a missing game concept; if a required product/game concept is unclear, keep the Define run blocked instead of allowing Planning to guess.
Raw idea type: game
Priority: high

Raw idea:
Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score.
The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay
