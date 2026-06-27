# Raw Idea

raw_idea_page_id: 38cb9e33-8429-819c-b792-c2bc94bb235d
chain_id: raw:NeonDrift_MVP:20260627151214
project_name: NeonDrift_MVP
idea_type: game
target_platform: Unity iOS
priority: high
requested_by: codex-rich-raw-idea-retry

## Raw Idea（原始想法）

Create an iOS-first Unity 6000.0.77f1 arcade game MVP named NeonDrift_MVP. The player is a rookie courier piloting a cyan hover ship through a collapsing neon data highway inside a cyber-city. The center playfield must read as a dangerous moving lane/track, not an abstract rectangle. The player must immediately understand: cyan ship = me, neon track = survival lane, pink shards = crash threat, gold/green glow cells = reward/boost, LEFT/RIGHT = drift between lanes. The first 10 seconds must teach by screen composition and motion, not a long tutorial. The game should feel richer than a single dodge prototype: lane drift, hazard waves, near-miss scoring, boost pickups, combo multiplier, pulse drain, short wave pacing, failure reason, retry reset, pause, sound toggle, and visible best score. Planning and Spec Review must define each system in separate detailed files so Development has no need to invent core behavior. Visual design must include layered moving background, luminous track rails, player trail, hazard warning, pickup pulse, score feedback, failure overlay, and clear typography. QA must include simulator video across at least 3 complete runs, screenshots for menu/gameplay/game-over/retry, runtime probe JSON, PlayMode test evidence, product experience review, first-run comprehension gate, visual richness gate, and gameplay function gate. Build must auto-run locally on Unity 6000.0.77f1 when available; no manual product-code intervention is allowed.

## Game Concept（遊戲概念）

Neon courier drift runner: a cyan hover ship survives a collapsing cyber data highway by drifting left/right between lanes, dodging pink crash shards, collecting glow cells, and chaining near misses for combo score.

## Player Goal（玩家目標）

Survive 60-second-style short runs as long as possible, keep pulse above zero, dodge hazards, collect boost cells, build combo/near-miss score, beat best score, and retry quickly after a visible failure reason.

## Core Gameplay（核心玩法）

Tap LEFT to drift one lane left; tap RIGHT to drift one lane right. The track scrolls toward the player. Pink hazard shards approach in readable patterns. Gold/green pickups restore pulse or increase combo. Near misses increase multiplier. Collision or pulse depletion triggers Drift Lost with reason and Retry.

## Core Objects（核心物件）

Cyan player hover ship, neon data track/lane rails, moving background light tunnel, pink hazard shards, gold boost cells, green combo cells, score HUD, pulse meter, combo/multiplier HUD, wave indicator, pause button, sound/settings, failure overlay, retry button, best score.

## Visual Direction（視覺方向）

High-polish neon arcade look: dark cyber-city depth, cyan/magenta/gold color language, animated lane rails, parallax light tunnel, player glow trail, hazard warning chevrons, pickup pulse rings, readable iPhone portrait HUD, large touch zones, safe-area support, no flat placeholder-only scene.

## Success Criteria（成功條件）

A first-time player can explain what the track is, what they control, what LEFT/RIGHT do, what to avoid, what to collect, why they failed, and what Retry does from screenshots/video alone. QA passes only with video, screenshots, runtime probes, PlayMode tests, first-run comprehension, visual richness, gameplay depth, and retry recovery evidence.

## Must Have（必須包含）

Detailed planning proposal split into sections; spec review with gameplay/control/HUD/visual/audio/QA acceptance details; Unity iOS simulator project; local Unity build; 3-run simulator QA video; screenshots; runtime probe; OPDCA + DMAIC control monitoring; no missing chain id; Notion docs synced.

## Must Not（不可包含）

No vague planning docs, no abstract rectangle track without meaning, no unclear LEFT/RIGHT behavior, no static or blank-looking screen, no placeholder-only squares, no QA pass based only on JSON, no single-run QA, no retry that leaves the player in a passive or unclear state.

## Reference（參考資料）

Use OpenClaw knowledge bases: Apple HIG, product experience first-run clarity, game quality visual richness, game system design, narrative visual storytelling, OpenGameArt asset sourcing and license register, OPDCA_DMAIC_CYCLE.

## Monetization Direction（收益方向）

Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.

## Compatibility Target（相容性目標）

iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.

## QA Requirement（QA 要求）

QA must hard fail unless product experience, human visual judgement, first-run gameplay comprehension, gameplay function playability, visual richness, three-run recording, screenshots, runtime probes, PlayMode XML, retry recovery, and delivery files are all present and Passed.
