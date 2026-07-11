# Initial Define Request

project_name: NeonDrift_MVP
define_page_id: 39ab9e33-8429-81de-9641-e01757cf18cc
define_run_id: notion-NeonDrift_MVP-define-20260711060915
chain_id: raw:NeonDrift_MVP:20260711060852

## Pipeline Request

Normalize this raw idea into canonical product definition for the OpenClaw pipeline.
Preserve the original idea. Do not invent a missing game concept as a confirmed fact; if a required product/game concept is unclear, keep it labeled as open question or candidate instead of allowing Planning to guess.
Define may expand the idea, but only as Interpretation, Expansion Candidate, Assumption, or Recommended-not-confirmed direction.
Every Expansion Candidate must include source cue, proposed direction, gameplay impact, visual/experience impact, risk, and decision status.
Planning must compare or select candidates with rationale; candidates must not become confirmed requirements without user approval or explicit downstream decision evidence.
External research rule: if Reference contains URLs, asset libraries, competitor examples, app-store guidelines, platform docs, or market examples, Define must convert them into Research Knowledge Cards instead of raw citations.
Research cards must preserve source_card_id, source_url, accessed_at, license_or_terms, usage_risk, design_implication, and do_not_use_directly. Unknown license or direct-use rights must be treated as pending/high risk until evidence-collector or ux-researcher verifies them.
Planning, Spec Review, Development, Build, and QA may use external references only through docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, and docs/research/Research_License_Risk_Register.md.
Raw idea type: game
Priority: high

Raw idea:
Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score.
The core

## Raw Idea（原始想法）

Create an iOS-first Unity quick game MVP named NeonDrift_MVP: a neon arcade drift runner where the player pilots a hover car through a moving light tunnel.
The full OpenClaw pipeline must run Raw Idea -> Define -> Planning -> Spec Review -> Development -> Build -> QA without manual product-code intervention.
The player goal is to survive as long as possible, collect boost cells, avoid hazard shards, build combo/near-miss score, and retry quickly for a better best score.
The core gameplay is left/right drift control with visible vehicle movement, track motion, hazard approach, boost pickup, pulse drain, failure reason, pause, and retry.
The game must be visually rich, immediately understandable, and deeper than a single static tap loop: clear objective, movement, scoring, hazards, boost/combo feedback, failure reason, pause, retry, and visible progression hooks.
Planning and Spec Review must define visual richness, gameplay depth, iconography, fonts, background layers, effects, compatibility targets, QA gates, and local iOS simulator delivery before Development starts.
Retry is accepted only when a human can see a clear transition from game-over to a fresh playable run: failure overlay removed, score/timer/run state reset, player/track motion resumes, and the after-retry screenshot/video differs from the game-over frame.
Build must auto-start with Unity 6000.0.77f1 when the licensed local Unity Editor is available. QA must include simulator screenshots, playthrough video, button/touch layout checks, and every core gameplay function check.
