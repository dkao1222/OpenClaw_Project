# Initial Request

project_name: NeonDrift_MVP
workspace_key: 382b9e3384298039b171c9b2a60ae644
run_id: notion-NeonDrift_MVP-0-12-20260627151229
chain_id: raw:NeonDrift_MVP:20260627151214
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260627151218

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

由 Raw Idea 正規化：Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual design must include layered moving background, luminous track rails, player trail, hazard warning, pickup pulse, score feedback, failure overlay, and clear typography. QA must include simulator video across at least 3 complete runs, screenshots for menu/gameplay/game-over/retry, runtime probe JSON, PlayMode test evidence, product experience review, first-run comprehension gate, visual richness gate, and gameplay function gate. Build must auto-run locally on Unity 6000.0.77f1 when available; no manual product-code intervention is allowed.
遊戲概念：Neon courier drift runner: a cyan hover ship survives a collapsing cyber data highway by drifting left/right between lanes, dodging pink crash shards, collecting glow cells, and chaining near misses for combo score.
玩家目標：Survive 60-second-style short runs as long as possible, keep pulse above zero, dodge hazards, collect boost cells, build combo/near-miss score, beat best score, and retry quickly after a visible failure reason.
必須包含：Detailed planning proposal split into sections; spec review with 

## Target Audience（目標受眾）

由 Raw Idea 中已提交的概念與平台推導目標受眾；若原始想法未指定，只能標記 open question，不可把預設玩家輪廓當成確定需求。

## Core Value（核心價值）

由 Raw Idea 提煉 1-3 個核心價值；核心價值必須回指已提交的 game concept/core gameplay/player goal。
核心玩法：Tap LEFT to drift one lane left; tap RIGHT to drift one lane right. The track scrolls toward the player. Pink hazard shards approach in readable patterns. Gold/green pickups restore pulse or increase combo. Near misses increase multiplier. Collision or pulse depletion triggers Drift Lost with reason and Retry.
核心物件：Cyan player hover ship, neon data track/lane rails, moving background light tunnel, pink hazard shards, gold boost cells, green combo cells, score HUD, pulse meter, combo/multiplier HUD, wave indicator, pause button, sound/settings, failure overlay, retry button, best score.
視覺方向：High-polish neon arcade look: dark cyber-city depth, cyan/magenta/gold color language, animated lane rails, parallax light tunnel, player glow trail, hazard warning chevrons, pickup pulse rings, readable iPhone portrait HUD, large touch zones, safe-area support, no flat placeholder-only scene.
成功條件：A first-time player can explain what the track is, what they control, what LEFT/RIGHT do, what to avoid, what to collect, why they failed, and what Retry does from screenshots/video alone. QA passes only with video, screenshots, runtime probes, PlayMode tests, first-run comprehension, visual richness, gameplay depth, and retry recovery evidence.
QA 要求：QA must hard fail unless product experience, human visual judgement, first-run gameplay comprehension, gameplay function playability, visual richness, three-run recording, screenshots, runtime probes, PlayMode XML, retry recovery, and delivery files are all present and Passed.

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
Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual de
